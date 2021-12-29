using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class CommentLikesRepository : Repository<CommentLike>, ICommentLikesRepository
    {
        public CommentLikesRepository(ApplicationDBContext context) : base(context)
        { }

        public async Task<CommentLike> FindInCommentLike(int id, string userId)
        {
            return await context.CommentLikes.Where(l => l.CommentId == id && l.UserId.Contains(userId)).SingleOrDefaultAsync();
        }
    }
}
