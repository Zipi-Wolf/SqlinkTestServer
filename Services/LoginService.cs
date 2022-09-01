using Microsoft.EntityFrameworkCore;
using SqlinkTest.Infrastructure;
using SqlinkTest.Interfaces;
using SqlinkTest.Models;
using SqlinkTest.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Services
{
    public class LoginService : ILoginService
    {

        private readonly IAsyncRepository<User> _userRepository;
        protected readonly Context _context;

        public LoginService(IAsyncRepository<User> userRepository, Context context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        public async Task<User> AuthenticateUser(UserLoginRequest login)
        {
            User user = null;

            //Validate the User Credentials
            //Check if password rigth 
            var currentUser =await _context.userLogins.Where(x => x.email == login.email).FirstOrDefaultAsync();
            if (currentUser.password == login.password)
            {
                //user =await _context.users.Where(u => u.id == currentUser.userId).FirstOrDefaultAsync(); 
                user = new User {id="1", name = "Test Test", team = "Developers" , joinedAt=new DateTime(2018,10,1) , avatar= "https://avatarfiles.alphacoders.com/164/thumb-164632.jpg"};
            }

            return user;
        }

    }
}
