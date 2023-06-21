using System;
using User.Domain.DTOS;
using User.Domain.Services;

namespace User.Infastructure.Services
{
    public class UserService : IUserService
    {
        public UserDTO GetUserByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            var dto = new UserDTO
            {
                Name = "Emre",
                Surname = "Ekiz",
                BirthDate = new DateTime(2000, 2, 4),
                Username = username
            };
            var dto1 = new UserDTO
            {
                Name = "abc",
                Surname = "Ekiz",
                BirthDate = new DateTime(2000, 2, 4),
                Username = username
            };
            return dto;
        }
    }
}
