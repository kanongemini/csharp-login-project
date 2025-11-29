using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        private static List<User> _users = new List<User>();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _users.FirstOrDefault(u => 
                    u.Email == model.Email && u.Password == model.Password);
                
                if (user != null)
                {
                    HttpContext.Session.SetString("UserName", user.Name);
                    HttpContext.Session.SetString("UserEmail", user.Email);
                    return RedirectToAction("Dashboard", "Home");
                }
                
                ModelState.AddModelError("", "Email ou senha invalidos");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Este email ja esta cadastrado");
                    return View(model);
                }

                var user = new User
                {
                    Id = _users.Count + 1,
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password
                };

                _users.Add(user);
                
                HttpContext.Session.SetString("UserName", user.Name);
                HttpContext.Session.SetString("UserEmail", user.Email);
                
                return RedirectToAction("Dashboard", "Home");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
