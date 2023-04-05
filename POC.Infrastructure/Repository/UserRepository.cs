using Microsoft.EntityFrameworkCore;
using POC.Core.Domain;
using POC.Core.Interfaces;
using POC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public ICollection<User> GetAll()
        {
            return _context.Users.OrderBy(p => p.UserID).ToList();
        }

        public User GetUserById(int ID)
        {
            var res= _context.Users.Where(p => p.UserID ==ID).FirstOrDefault();
            return res;

        }
    }
}
