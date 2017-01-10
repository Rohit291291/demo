using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace Code_first.Models
{
    public class product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }

    public class DbProduct : DbContext
    {
        public DbSet<product> product { get; set; }

        
    }

}