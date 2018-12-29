using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.General_Operations
{
    internal class RoleController
    {
        public static IList<Role> GetRoles()
        {
            IRoleRepository roleRepository = new RoleRepository();
            return roleRepository.GetAll();
        }
    }
}
