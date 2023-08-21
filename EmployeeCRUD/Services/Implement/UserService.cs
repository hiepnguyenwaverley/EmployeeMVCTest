using EmployeeCRUD.Models;

namespace EmployeeCRUD.Services.Implement
{
    public class UserService:IUserService
    {
        public List<User> UserList = new List<User> {
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Duongqua",
                NameUser ="Duong Qua",
                Email="quanhi@123.com",
                Password="123"
            },

                 new User
            {
                Id = Guid.NewGuid(),
                UserName = "CoLong",
                NameUser ="Tieu Long Nu",
                Email="coco@123.com",
                Password="123"
            }
           
        };

        public bool AddUser(User newuser)
        {
            if (UserList == null)
            {
                return false;
            }
            newuser.Id = Guid.NewGuid();//khi add list moi se tao luon id moi 
            UserList.Add(newuser);
            return true;
        }
        public bool UpdateUser(Guid id, User updateUser)
        {
            if(id==Guid.Empty||updateUser==null)
            {
                return false;
            }
            var user = UserList.FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                user.UserName = updateUser.UserName;
                user.NameUser = updateUser.NameUser;
                user.Password = updateUser.Password;
                user.Email = updateUser.Email; 
                return true;
            }
            return false;

        }

        public bool DeleteUser(Guid id)
        {
            {
                var user = UserList.FirstOrDefault(item => item.Id == id);
                if (user != null)
                {
                    UserList.Remove(user);
                    return true;
                }
                return false;
            }
        }

        public List<User> GetAll()
        {
            return UserList;
        }
        public User? GetById(Guid id)
        {
            return UserList.FirstOrDefault(item => item.Id == id);
        }

        public bool LoginUser(User loginuser)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User registeruser)
        {
            throw new NotImplementedException();
        }

 

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
