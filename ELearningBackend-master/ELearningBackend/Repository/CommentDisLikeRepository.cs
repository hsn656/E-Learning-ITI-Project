using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class CommentDisLikeRepository: Repository<CommentDisLike>, ICommentDisLikeRepository
    {
        public CommentDisLikeRepository(ApplicationDBContext context) : base(context)
        { }
        public async Task<CommentDisLike> FindInCommentDisLike(int id, string userId)
        {
            return await context.CommentDisLikes.Where(l => l.CommentId == id && l.UserId.Contains(userId)).SingleOrDefaultAsync();
        }
    }
}
