using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Models
{
    public class UserLoginDetails :BaseEntity
    {
        public string userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
