
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Services.Implement
{
    public class DepartmentService : IDepartmentService
    {
        public List<Department> DepartmentList = new List<Department>
        {   new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName="Phong Kinh Doanh",
                Address="TPHCM",
                Status="Enable",
                Phone="09012345",
                Description="PKD",

            },
            new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName="Phong Ke Toan",
                Address="TPHCM",
                Status="Enable",
                Phone="09012345",
                Description="PKT",

            },
            new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName="Phong Ki Thuat",
                Address="TPHCM",
                Status="Enable",
                Phone="09012345",
                Description="PKThuat",

            },
            new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName="Phong Hanh Chinh",
                Address="TPHCM",
                Status="Enable",
                Phone="09012345",
                Description="PHC",

            },

        };

        public bool AddDepartment(Department newDepart)
        {
            if (DepartmentList == null)
            {
                return false;
            }
            newDepart.Id = Guid.NewGuid();//khi add list moi se tao luon id moi 
            DepartmentList.Add(newDepart);
            return true;
        }

        public bool DeleteDepartment(Guid id)
        {
            var department = DepartmentList.FirstOrDefault(item => item.Id == id);
            if (department != null)
            {
                DepartmentList.Remove(department);
                return true;
            }
            return false;
        }

        public List<Department> GetAll()
        {
            return DepartmentList;
        }

        public Department? GetById(Guid id)
        {
            return DepartmentList.FirstOrDefault(item => item.Id == id);
        }



        public bool UpdateDepartment(Guid id, Department updateDepart)
        {
            if (id == Guid.Empty || updateDepart == null)
            {
                return false;
            }
            var department = DepartmentList.FirstOrDefault(item => item.Id == id);
            if (department != null)
            {
                department.DepartmentName = updateDepart.DepartmentName;
                department.Address = updateDepart.Address;
                department.Status = updateDepart.Status;
                department.Phone = updateDepart.Phone;
                department.Description = updateDepart.Description;
                return true;
            }
            return false;
        }
    }
}
