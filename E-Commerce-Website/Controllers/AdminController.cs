using E_Commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace E_Commerce_Website.Controllers
{
    public class AdminController : Controller
    {

        private myContext _context;
        public AdminController(myContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           var admin_session = HttpContext.Session.GetString("admin_session");
            if (admin_session != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }    
            
        }
        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string adminEmail, string adminPassword)
        {
            var val = _context.admins.FirstOrDefault(a => a.Admin_Email==adminEmail);
            if (val != null && val.Admin_Password==adminPassword) 
            {
                HttpContext.Session.SetString("admin_session", val.Admin_Id.ToString());
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Incorrect Username or Password";
                return View();
            }
           
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin_session");
            return RedirectToAction("Login");
        }
    }
}
