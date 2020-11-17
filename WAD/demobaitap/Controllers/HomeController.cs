using Microsoft.AspNetCore.Mvc;
using demobaitap.Models;

namespace demobaitap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage
            {
                Message = "Hello MVC"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message Chaned";
            return View(obj);
        }
    }
}
