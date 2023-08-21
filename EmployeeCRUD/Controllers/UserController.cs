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
            TempData["ResultOk"] = "Add User Successfully !";
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
            TempData["ResultOk"] = "Login Successfully !";
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
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id == null||id==Guid.Empty)
            {
                return NotFound();
            }
            var user = _userService.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            bool result = _userService.UpdateUser(user.Id, user);

            TempData["ResultOk"] = "Update Successfully !";
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var user = _userService.GetById(id.Value);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Remove(Guid? id)
        {
            var user = _userService.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }
            _userService.DeleteUser(id.Value);
            TempData["ResultOk"] = "Delete Successfully !";
            return RedirectToAction("Index");
        }
    }
}
