using SqlinkTest.Models;
using SqlinkTest.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Interfaces
{
    public interface ILoginService
    {
        Task<User> AuthenticateUser(UserLoginRequest login);
        public string GenerateJSONWebToken();
    }
}
