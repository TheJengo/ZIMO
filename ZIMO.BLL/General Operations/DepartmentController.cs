using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.General_Operations
{
    internal class DepartmentController
    {
        public static IList<Department> GetDepartments()
        {
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            return departmentRepository.GetAll().Select(x=>x = departmentRepository.GetSingle(y=>y.Id.Equals(x.Id),y=>y.Users)).ToList();
        }

        public static void ManageDepartment(Department department, EntityState entityState)
        {
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            if (entityState == EntityState.Added)
            {
                department.EntityState = EntityState.Added;
                departmentRepository.Add(department);
            }
            else
            {
                department.EntityState = entityState;
                departmentRepository.Update(department);
            }
        }
    }
}
