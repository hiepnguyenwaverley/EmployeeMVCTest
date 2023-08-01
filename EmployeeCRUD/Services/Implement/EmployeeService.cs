using EmployeeCRUD.Models;
using EmployeeCRUD.Models.Enum;

namespace EmployeeCRUD.Services.Implement
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> EmployeeList = new List<Employee> { 
            new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "A",
                LastName = "Nguyen Van",
                BirthDay = DateTime.Now.AddYears(-19),
                Gender = GenderEnum.Male,
                Address = "Thu Duc Tp HCM",
                Description = "Note"
            }
        };
        public bool DeleteEmployee(Guid id)
        {
            var employee = EmployeeList.FirstOrDefault(item => item.Id == id);

            if (employee != null)
            {
                EmployeeList.Remove(employee);
                return true;
            }
            return false;
        }

        public List<Employee> GetAll()
        {
            return EmployeeList;
        }

        public Employee? GetById(Guid id)
        {
            return EmployeeList.FirstOrDefault(item => item.Id == id);
        }

        public bool SaveEmployee(Employee newEmp)
        {
            if (newEmp == null)
            {
                return false;
            }
            EmployeeList.Add( new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = newEmp.FirstName,
                LastName = newEmp.LastName,
                BirthDay = newEmp.BirthDay,
                Gender = newEmp.Gender,
                Address = newEmp.Address,
                Description = newEmp.Description
            });
            return true;
        }

        public bool UpdateEmployee(Guid id, Employee updateEmp)
        {
            if (id == Guid.Empty || updateEmp == null)
            {
                return false;
            }

            var employee = EmployeeList.FirstOrDefault(item => item.Id == id);
            
            if (employee != null)
            {
                employee.FirstName = updateEmp.FirstName;
                employee.LastName = updateEmp.LastName;
                employee.BirthDay = updateEmp.BirthDay;
                employee.Gender = updateEmp.Gender;
                employee.Address = updateEmp.Address;
                employee.Description = updateEmp.Description;
                return true;
            }

            return false;
        }
    }
}
