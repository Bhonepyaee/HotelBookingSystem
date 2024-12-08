using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
