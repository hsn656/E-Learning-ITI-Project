using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class PostDisLikeRepository : Repository<PostDisLike>, IPostDisLikeRepository
    {
        public PostDisLikeRepository(ApplicationDBContext context) : base(context)
        {

        }
        public async Task<PostDisLike> FindInPostDisLike(int id, string userId)
        {
            return await context.DisLikes.Where(l => l.PostId == id && l.UserId.Contains(userId)).SingleOrDefaultAsync();
        }
    }
}
