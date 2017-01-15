using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using delavShop.Models;

namespace delavShop.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        CreamContext db=new CreamContext();

        public ActionResult Index()
        {
            IEnumerable<Cream> creams = db.Creams;
            ViewBag.Creams = creams;
            return View();
        }
    }
}