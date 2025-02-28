using Basic_Login_Registration.Data;
using Basic_Login_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Basic_Login_Registration.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Authentication/Register")]
        public ActionResult Register()
        {
            return View("~/Views/Authentication/Register.cshtml");
        }

        [HttpPost]
        [Route("Authentication/Register")]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View("~/Views/Authentication/Register.cshtml", user);
        }

        [HttpGet]
        [Route("Authentication/Login")]
        public ActionResult Login()
        {
            return View("~/Views/Authentication/Login.cshtml");
        }

        [HttpPost]
        [Route("Authentication/Login")]
        public ActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                // Redirect based on role
                if (user.Role == "event host")
                {
                    ViewBag.Message = "Host login";
                    return View("~/Views/Home/EventHostDashboard.cshtml");
                }
                else if (user.Role == "attendee")
                {
                    ViewBag.Message = "Attendee login";
                    return View("~/Views/Home/AttendeeDashboard.cshtml");
                }
            }

            // Show error message
            ViewBag.ErrorMessage = "Invalid username or password";
            return View("~/Views/Authentication/Login.cshtml");
        }
    }
}
