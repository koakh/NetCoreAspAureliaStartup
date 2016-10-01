using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modern.Controllers
{
    public class Home : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string model = "Hello World from ASP.NET Core 1.0!";
            return View("Index", model);
        }
    }
}
