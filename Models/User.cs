using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Models
{
    public class User :BaseEntity
    {
        public string id { get; set; }
        public string name { get; set; }
        public string team { get; set; }
        public DateTime joinedAt { get; set; }
        public string avatar { get; set; }


    }
}
