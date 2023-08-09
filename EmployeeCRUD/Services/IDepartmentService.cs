using EmployeeCRUD.Models;

namespace EmployeeCRUD.Services
{
    public interface IDepartmentService
    {
        public List<Department> GetAll();
        public Department? GetById(Guid id);
        public bool AddDepartment(Department newDepart);
        public bool UpdateDepartment (Guid id, Department updateDepart);
        public bool DeleteDepartment (Guid id);
 
    }
}
