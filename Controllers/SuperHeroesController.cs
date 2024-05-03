using AutoMapper;
using kamui.Models;
using kamui.Models.DTOs.SuperHeroDTO;
using Microsoft.AspNetCore.Mvc;

namespace kamui.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroesController : ControllerBase
	{

        private readonly IMapper _mapper;

        public SuperHeroesController(IMapper mapper)
        {
            _mapper = mapper;
            
        }

		private static List<SuperHeroe> heroes = new List<SuperHeroe>
		{
			new SuperHeroe
			{
				Id= 1,
				firstName = "Mateo",
				lastName = "Vranych",
				username = "matu",
				place = "Córdoba",
				
			},
			new SuperHeroe
			{
				Id= 2,
				firstName = "Alexis",
				lastName = "Prieto",
				username = "Alex",
				place = "Córdoba",

			}
		};

		[HttpGet]

		public IActionResult GetHeroes()
		{
			return Ok(heroes);
		}

		[HttpPost]

		public IActionResult addHero(SuperHeroDTO newHero)
		{
			var hero = _mapper.Map<SuperHeroe>(newHero);	
			heroes.Add(hero);

			return Ok(heroes.Select(hero => _mapper.Map<SuperHeroDTO>(hero)));

			
		}
	}
}
