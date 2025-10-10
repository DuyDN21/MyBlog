using Microsoft.AspNetCore.Mvc;

namespace MyBlog.App.Controllers
{
    public class AuthenController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
