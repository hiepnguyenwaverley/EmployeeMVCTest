using EmployeeCRUD.Models;
using EmployeeCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class MemberController : Controller
    {
        
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
     
        public IActionResult Index()
        {
            List<Employee> Listemployee=_employeeService.GetAll();
            return View(Listemployee);
        }
    }
}
