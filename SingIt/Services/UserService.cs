using SingIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingIt.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserService(ApplicationDbContext db)
        {
            _dbContext = db;
        }

        public User GetUserById(string id)
        {
            var user = _dbContext.Users.Where(x => x.Id.Equals(id)).FirstOrDefault();
            
            return user;
        }
    }
}
