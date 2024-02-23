using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceAppDemo.Filters;

namespace ServiceAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult clientIndex()
        {
            return View("~/Views/HomeClient/Index.cshtml");
        }
        public ActionResult operatorIndex()
        {
            return View("~/Views/HomeOperator/Index.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AuthorizeUser(idOperacion: 3)]        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult parametros()
        {
            
            return View();
        }
    }
}