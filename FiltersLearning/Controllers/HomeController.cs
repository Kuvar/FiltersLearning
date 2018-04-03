using FiltersLearning.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersLearning.Controllers
{
    public class HomeController : Controller
    {

        [CustomAuthorization]
        [CustomAction]
        [CustomResultAttribute]
        [CustomExceptionAttribute]
        public ActionResult Index()
        {
            ViewBag.Message = "Index Action of Home controller is being called.";
            return View();
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