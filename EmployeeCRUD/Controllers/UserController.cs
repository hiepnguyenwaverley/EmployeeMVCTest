using EmployeeCRUD.Models;
using EmployeeCRUD.Services;
using EmployeeCRUD.Services.Implement;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            List<User> users = _userService.GetAll();
            return View(users);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (user == null)
            {
                return View(user);
            }
            _userService.AddUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user == null)
            {
                return View(user);
            }
            _userService.AddUser(user);
            return RedirectToAction("Login");
        }
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user == null)
            {
                return View(user);
            }
            _userService.AddUser(user);
            return RedirectToAction("Index");
        }

    }
}
