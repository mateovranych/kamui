using kamui.Models;
using Microsoft.EntityFrameworkCore;

namespace kamui.Context
{
	public class appDbContext: DbContext
	{
		public appDbContext(DbContextOptions<appDbContext> options): base(options)
		{

		}


		DbSet<User> Usuarios { get; set; }

	}
}
