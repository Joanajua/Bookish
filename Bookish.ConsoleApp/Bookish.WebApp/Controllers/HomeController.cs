using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;


namespace Bookish.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entities = new BookRepository();
            return View(entities.GetBooks());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}