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
            return View();
        }

        ////filtros de accion
        ////Despues de invocar la accion
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    //base.OnActionExecuting(filterContext);
        //    Debug.WriteLine("Antes de invocar la accion-OnActionExecuting");
        //}

        ////Despues de invocar la accion
        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    //base.OnActionExecuted(filterContext);
        //    Debug.WriteLine("Despues de invocar la accion-OnActionExecuted");

        //}
    }


}