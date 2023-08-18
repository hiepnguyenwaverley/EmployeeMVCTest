using EmployeeCRUD.Models;

namespace EmployeeCRUD.Services
{
    public interface IUserService
    {
        public User GetById(int id);
        public List<User> GetAll();
        public bool AddUser(User user);
        public bool UpdateUser(User user);
        public bool DeleteUser(int id);
        public bool LoginUser(User loginuser);
        public bool RegisterUser(User registeruser);
    }
}
