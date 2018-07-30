using System;

namespace Domain.Repository.Entities
{
	public class User
    {
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime DateCreation { get; set; }
    }
}
