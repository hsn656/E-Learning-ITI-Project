using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class PostLikeRepository: Repository<PostLike>, IPostLikeRepository
    {
        public PostLikeRepository(ApplicationDBContext context) : base(context)
        { }

        public async Task<PostLike> FindInPostLike(int id, string userId)
        {
            return await context.Likes.Where(l => l.PostId == id && l.UserId.Contains(userId)).SingleOrDefaultAsync();
        }
    }
}
