using Dapper;
using Domain.Repository;
using Domain.Repository.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
	public class UserRepository : IUserRepository
	{
		public int CreateUser(User user)
		{
			using (var connection = new SqlConnection(CONNECTION_STRING))
			{
				return connection.QuerySingleOrDefault<int>(CREATE_USER, user);
			}
		}

		public void UpdateUser(User user)
		{
			using (var connection = new SqlConnection(CONNECTION_STRING))
			{
				connection.Execute(UPDATE_USER, user);
			}
		}

		public User GetUserById(int userId)
		{
			using (var connection = new SqlConnection(CONNECTION_STRING))
			{
				return connection.QuerySingleOrDefault<User>(GET_USER_BY_ID, new { UserId = userId });
			}
		}

		public List<User> GetUsersByFilter()
		{
			using (var connection = new SqlConnection(CONNECTION_STRING))
			{
				return connection.Query<User>(GET_USERS_BY_FILTER).AsList();
			}
		}

		private const string CONNECTION_STRING = "Data Source=192.168.99.100,7000;User ID=sa;Password=@AuthorizationDB1";

		private const string CREATE_USER = @"
			INSERT INTO User (
				Name,
				Surname,
				DateCreation)
			VALUES (
				@Name,
				@Surname,
				@DateCreation)
			SELECT SCOPE_IDENTITY()";

		private const string GET_USER_BY_ID = @"
			SELECT 
				UserId,
				Name,
				Surname,
				DateCreation
			FROM
				User
			WHERE 
				UserId = @UserId";

		private const string GET_USERS_BY_FILTER = @"
			SELECT 
				Name,
				Surname,
				DateCreation
			FROM 
				User
			WHERE
				{0}";

		private const string UPDATE_USER = @"
			UPDATE 
				User
			SET
				Name = @Name,
				Surname = @Surname
			WHERE
				UserId = @UserId";
	}
}
