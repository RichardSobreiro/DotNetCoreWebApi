using Domain.Repository.Entities;
using System.Collections.Generic;

namespace Domain.Repository
{
	public interface IUserRepository
    {
		int CreateUser(User user);
		void UpdateUser(User user);
		User GetUserById(int userId);
		List<User> GetUsersByFilter();
    }
}
