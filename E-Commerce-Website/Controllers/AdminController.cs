using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login() {
            return View();
        }
    }
}
