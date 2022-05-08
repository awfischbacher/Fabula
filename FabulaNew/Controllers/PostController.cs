using Microsoft.AspNetCore.Mvc;

namespace Fabula.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
