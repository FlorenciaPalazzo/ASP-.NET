using Microsoft.AspNetCore.Mvc;

namespace WebMVCEjemplos.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home o /Home/index
        public IActionResult Index(int id = 50)
        {
            return Content($"This is the Home controller with default param: {id}");
        }

        [Route("Hello/{firstName}/{lastName}")]
        public IActionResult Greeting(string firstName, string lastName)
        {
            return Content($"Hello {firstName} {lastName} from module 4 demo 2");
        }


        // GET: /Home/ParamExample/100
        public IActionResult ParamExample(string id)
        {
            return Content("My param is: " + id);
        }

        // GET: /Home/RouteDataExample/77
        public IActionResult RouteDataExample()
        {
            string controller = (string)RouteData.Values["Controller"];
            string action = (string)RouteData.Values["action"];
            string id = (string)RouteData.Values["id"];
            return Content($"Action information: the action is in {controller} controller, the action name is {action} and the id value is {id}");
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.Message = "ViewBag Example";
            return View();
        }

        public IActionResult ViewDataExample()
        {
            ViewData["Message"] = "ViewData Example";
            return View();
        }
    }
}


