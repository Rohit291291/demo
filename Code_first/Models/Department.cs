using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_first.Models
{
    public class Department
    {
         public int id { get; set; }
        public string name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employee { get; set; }
    }
}