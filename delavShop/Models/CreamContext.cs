using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace delavShop.Models
{
    public class CreamContext:DbContext
    {
        public  DbSet<Cream> Creams { get; set; }
        public  DbSet<Purshase> Purshases { get; set; } 
    }
}