using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
