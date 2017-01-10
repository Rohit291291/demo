using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Code_first.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Address { get; set; }



    }
    public class Dbcontact : DbContext
    {
        public DbSet<Contact> Contact { get; set; }

        public System.Data.Entity.DbSet<Code_first.Models.product> products { get; set; }
    }
}