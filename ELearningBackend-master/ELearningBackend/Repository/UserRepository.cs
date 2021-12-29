using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class UserRepository:Repository<ApplicationUser>,IUserRepository
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {

        }

        public async Task<ApplicationUser> GetByIdAsync(string id)
        {
            return await context.Users.FindAsync(id);
        }

    }
}
