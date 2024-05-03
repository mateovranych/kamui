using System.ComponentModel.DataAnnotations;

namespace kamui.Models.DTOs.UserDTO
{
    public class ShowUserDTO
    {

		[Key]
		public int Id { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public string username { get; set; }
	}
}
