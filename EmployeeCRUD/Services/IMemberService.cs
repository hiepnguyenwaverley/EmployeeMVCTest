using EmployeeCRUD.Models;
namespace EmployeeCRUD.Services
{
    public interface IMemberService
    {
        public bool AssignMember(Employee member);
        public bool RemoveMember(Employee member);
    }
}
