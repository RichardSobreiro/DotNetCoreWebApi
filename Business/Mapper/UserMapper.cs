using Domain.Business.Dto;
using Domain.Repository.Entities;
using System.Collections.Generic;

namespace Business.Mapper
{
	public static class UserMapper
    {
		public static UserDto CreateDto(this User user)
		{
			return new UserDto()
			{
				userId = user.UserId,
				name = user.Name,
				surname = user.Surname,
				dateCreation = user.DateCreation
			};
		}

		public static User CreateEntity(this UserDto userDto)
		{
			return new User
			{
				UserId = userDto.userId,
				Name = userDto.name,
				Surname = userDto.surname,
				DateCreation = userDto.dateCreation
			};
		}

		public static List<UserDto> CreateDto(this List<User> users)
		{
			return users.ConvertAll(u => u.CreateDto());
		}
    }
}
