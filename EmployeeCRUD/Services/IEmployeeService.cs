using EmployeeCRUD.Models;

namespace EmployeeCRUD.Services
{
    public interface IEmployeeService
    {
        public List<Employee> GetAll();
        public Employee? GetById(Guid id);
        public bool UpdateEmployee(Guid id, Employee updateEmp);
        public bool SaveEmployee(Employee newEmp);
        public bool DeleteEmployee(Guid id);

    }
}
