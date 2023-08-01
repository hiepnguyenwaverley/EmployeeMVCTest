using EmployeeCRUD.Models;
using EmployeeCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            List<Employee> objCatlist = _employeeService.GetAll();
            return View(objCatlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee empobj)
        {
            if (ModelState.IsValid)
            {
                _employeeService.SaveEmployee(empobj);
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var emp = _employeeService.GetById(id.Value);

            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee empobj)
        {
            if (ModelState.IsValid)
            {
                bool result = _employeeService.UpdateEmployee(empobj.Id, empobj);
                if (result)
                {
                    TempData["ResultOk"] = "Data Updated Successfully !";
                } else
                {
                    TempData["ResultOk"] = "Data Updated Fail !";
                }
                
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }
            var emp = _employeeService.GetById(id.Value);

            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(Guid? id)
        {
            var deleterecord = _employeeService.GetById(id.Value);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _employeeService.DeleteEmployee(id.Value);
            //_context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully !";
            return RedirectToAction("Index");
        }


    }
}
