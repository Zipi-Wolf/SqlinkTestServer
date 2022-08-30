using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Models.Dto
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public User personalDetails { get; set; }
    }
}
