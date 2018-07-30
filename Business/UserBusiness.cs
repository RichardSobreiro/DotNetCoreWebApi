using System.Collections.Generic;
using Business.Mapper;
using Domain.Business.Dto;
using Domain.Business.Interfaces;
using Domain.Repository;

namespace Business
{
	public class UserBusiness : IUserBusiness
	{
		public int CreateUser(UserDto user)
		{
			return _userRepository.CreateUser(user.CreateEntity());
		}

		public void UpdateUser(UserDto user)
		{
			_userRepository.UpdateUser(user.CreateEntity());
		}

		public UserDto GetUserById(int userId)
		{
			var user = _userRepository.GetUserById(userId);
			return user.CreateDto();
		}

		public List<UserDto> GetUsersByFilter()
		{
			var users = _userRepository.GetUsersByFilter();
			return users.CreateDto();
		}

		public UserBusiness(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		private IUserRepository _userRepository;
	}
}
