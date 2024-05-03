﻿using System.ComponentModel.DataAnnotations;

namespace kamui.Models.DTOs.UserDTO
{
    public class CreateUserDTO
    {

		[Key]
		public int Id { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public string username { get; set; }

		public string email { get; set; }

		public string password { get; set; }

		public string role { get; set; }

		public string token { get; set; }

	}
}
