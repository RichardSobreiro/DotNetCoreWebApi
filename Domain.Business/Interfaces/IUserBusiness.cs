using Domain.Business.Dto;
using System.Collections.Generic;

namespace Domain.Business.Interfaces
{
	public interface IUserBusiness
    {
		int CreateUser(UserDto user);
		void UpdateUser(UserDto user);
		UserDto GetUserById(int userId);
		List<UserDto> GetUsersByFilter();
	}
}
