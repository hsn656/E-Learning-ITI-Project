using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface IUserRepository:IRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetByIdAsync(string id);
    }
}
