using EmployeeCRUD.Models;

namespace EmployeeCRUD.Services
{
    public interface IUserService
    {
        public User GetById(Guid id);
        public List<User> GetAll();
        public bool AddUser(User user);
        public bool UpdateUser(Guid id,User updateUser);
        public bool DeleteUser(Guid id);
        public bool LoginUser(User loginuser);
        public bool RegisterUser(User registeruser);
        
    }
}
