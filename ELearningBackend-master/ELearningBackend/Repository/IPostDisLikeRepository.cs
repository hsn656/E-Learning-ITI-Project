using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface IPostDisLikeRepository : IRepository<PostDisLike>
    {
        Task<PostDisLike> FindInPostDisLike(int id, string userId);

    }
}
