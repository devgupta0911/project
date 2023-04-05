using POC.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Core.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int UserID);

        ICollection<User> GetAll();
    }
}
