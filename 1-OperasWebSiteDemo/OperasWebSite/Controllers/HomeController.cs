using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using OperasWebSite.Filters;

namespace OperasWebSite.Controllers
{
    public class HomeController : Controller
    {
        [MyActionFilter]
        // GET: Home
        public ActionResult Index()
        {
            
        }
        public ActionResult About()
        {

            ViewBag.Message = "Contenido en  view About";
            return View();
        }

    }


}