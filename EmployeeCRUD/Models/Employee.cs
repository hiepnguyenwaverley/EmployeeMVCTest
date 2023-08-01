using EmployeeCRUD.Models.Enum;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public GenderEnum GenderEnumList { get; set; }
    }
}
