using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.App.Models;
using MyBlog.DataAccess.Models;

namespace MyBlog.App.Controllers
{
    public class AuthenController : Controller
    {
        private PersonalBlogContext _dbContext;

        public AuthenController(PersonalBlogContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var user = _dbContext.Users.FirstOrDefault(u => u.Email == loginViewModel.Email && u.Password == loginViewModel.Password);

            if(user is null)
            {
                ModelState.AddModelError("", "Sai email hoặc mật khẩu.");
                return View(loginViewModel);
            }

            var claims = new List<Claim> 
            { 
                new(ClaimTypes.Name, user.Email),
                new(ClaimTypes.Role, user.Role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            var authProps = new AuthenticationProperties
            {
                IsPersistent = loginViewModel.RememberMe,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProps);

            return Redirect(returnUrl ?? "/");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if (viewModel.Password != viewModel.RetypePassword)
            {
                ModelState.AddModelError("", "Mật khẩu xác nhận không khớp.");
                return View();
            }

            var user = new User
            {
                Email = viewModel.Email,
                Password = viewModel.Password,
                Username = viewModel.Username,
                Role = "user"
            };

            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return RedirectToAction("Login", "Authen");
        }
    }
}
