using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace delavShop.Models
{
    public class CreamDbInitializer:DropCreateDatabaseAlways<CreamContext>
    {
        protected override void Seed(CreamContext db)
        {
            db.Creams.Add(new Cream {Name = "Для рук", Author = "Делав", Price = 150});
            db.Creams.Add(new Cream {Name = "Для зняття макіяжу", Author = "Делав", Price = 300});
            db.Creams.Add(new Cream {Name = "Гелеронка", Author = "Делав", Price = 500});
            base.Seed(db);
        }
    }
}