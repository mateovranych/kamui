using kamui.Models;
using AutoMapper;

using kamui.Models.DTOs.UserDTO;
using kamui.Models.DTOs.SuperHeroDTO;

namespace kamui.Helpers
{
	public class autoMapperProfile : Profile
	{

        public autoMapperProfile()
        {

			    CreateMap<SuperHeroe, SuperHeroDTO>();
				CreateMap<SuperHeroDTO, SuperHeroe>();
			
            
        }
    }
}
