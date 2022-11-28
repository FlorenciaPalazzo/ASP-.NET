using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace OperasWebSite.Filters
{
    public class MyActionFilterAttribute:ActionFilterAttribute
    {
        //mejor hacer un filtro personalizado en una clase aparte para no hacerlo en Home y que quede protegido.
        //Queremos que quede publico

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            Debug.WriteLine("Antes de invocar la accion-OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            Debug.WriteLine("Despues de invocar la accion-OnActionExecuted");
        }
    }
}

