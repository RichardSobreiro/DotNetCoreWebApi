using Domain.Business.Dto;
using Domain.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Presentation.Controllers
{
	[Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpPost("user")]
        public int CreateUser([FromBody]UserDto user)
        {
			return _usersBusiness.CreateUser(user);
        }


		[HttpGet("user/{userId}")]
		public UserDto GetUserById(int userId)
		{
			return _usersBusiness.GetUserById(userId);
		}

		[HttpGet]
		public List<UserDto> GetUsers()
		{
			return _usersBusiness.GetUsersByFilter();
		}

		[HttpPut("user")]
		public void UpdateUser([FromBody]UserDto user)
		{
			_usersBusiness.UpdateUser(user);
		}

		public UsersController(IUserBusiness usersBusiness)
		{
			_usersBusiness = usersBusiness;
		}

		private IUserBusiness _usersBusiness;
    }
}
