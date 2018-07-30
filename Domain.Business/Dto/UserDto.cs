using System;

namespace Domain.Business.Dto
{
	public class UserDto
    {
		public int userId { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public DateTime dateCreation { get; set; }
	}
}
