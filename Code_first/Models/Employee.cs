using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_first.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }
        
        public string salary { get; set; }

        public Department Department { get; set; }
    }
}