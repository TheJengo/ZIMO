using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.DAL.Concretes
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
    }
}
