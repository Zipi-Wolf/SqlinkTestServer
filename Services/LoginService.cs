using Microsoft.EntityFrameworkCore;
using SqlinkTest.Infrastructure;
using SqlinkTest.Interfaces;
using SqlinkTest.Models;
using SqlinkTest.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace SqlinkTest.Services
{
    public class LoginService : ILoginService
    {
        private IConfiguration _config;
        private readonly IAsyncRepository<User> _userRepository;
        protected readonly Context _context;

        public LoginService(IConfiguration config , IAsyncRepository<User> userRepository, Context context)
        {
            _config = config;
            _userRepository = userRepository;
            _context = context;
        }

        public async Task<User> AuthenticateUser(UserLoginRequest login)
        {
            User user = null;

            //Validate the User Credentials
            //Check if password rigth 
            //var currentUser =await _context.userLogins.Where(x => x.email == login.email).FirstOrDefaultAsync();
            //if (currentUser.password == login.password)
            //{
                //user =await _context.users.Where(u => u.id == currentUser.userId).FirstOrDefaultAsync(); 
                user = new User {id="1", name = "Test Test", team = "Developers" , joinedAt=new DateTime(2018,10,1) , avatar= "https://avatarfiles.alphacoders.com/164/thumb-164632.jpg"};
            //}

            return user;
        }

        public string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
