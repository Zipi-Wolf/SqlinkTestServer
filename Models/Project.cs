using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Models
{
    public class Project :BaseEntity
    {
        public string id { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public int durationInDays { get; set; }
        public int bugsCount { get; set; }
        public bool madeDadeline { get; set; }


    }
}
