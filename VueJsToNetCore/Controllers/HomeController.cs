using Microsoft.AspNetCore.Mvc;
using VueJsToNetCore.ViewModel;

namespace VueJsToNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody]User user)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test()
        {
           return View(); // added test controller    
        }
    }
}
