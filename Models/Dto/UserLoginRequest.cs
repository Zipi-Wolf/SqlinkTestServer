using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Models.Dto
{
    public class UserLoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
