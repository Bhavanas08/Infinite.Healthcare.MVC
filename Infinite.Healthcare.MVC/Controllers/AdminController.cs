using Microsoft.AspNetCore.Mvc;

namespace Infinite.Healthcare.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
