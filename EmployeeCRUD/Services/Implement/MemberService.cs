
using EmployeeCRUD.Models;
namespace EmployeeCRUD.Services.Implement
{
    public class MemberService
    {
        public MemberService() { }
        public List<Employee> employees = new List<Employee>();
     public List<Employee> GetAll()
        {
            return employees;
        }
        
    }
}
