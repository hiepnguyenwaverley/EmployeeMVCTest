using EmployeeCRUD.Models;
using EmployeeCRUD.Services;
using EmployeeCRUD.Services.Implement;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            List<Department> depart = _departmentService.GetAll();
            return View(depart);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Department department)
        {
            if (department == null)
            {
                return View(department);
            }
            _departmentService.AddDepartment(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var depart = _departmentService.GetById(id.Value);

            if (depart == null)
            {
                return NotFound();
            }
            return View(depart);
        }
        [HttpPost]
        public IActionResult Edit(Department depart)
        {

            bool ketqua = _departmentService.UpdateDepartment(depart.Id, depart);
        

            return RedirectToAction("Index");


        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var depar= _departmentService.GetById(id.Value);

            if (depar == null)
            {
                return NotFound();
            }
            return View(depar);
        }

        [HttpPost]
       
        public IActionResult Remove(Guid? id)
        {
            var depart = _departmentService.GetById(id.Value);
            if (depart == null)
            {
                return NotFound();
            }
            _departmentService.DeleteDepartment(id.Value);
            return RedirectToAction("Index");
        }
    }
}
