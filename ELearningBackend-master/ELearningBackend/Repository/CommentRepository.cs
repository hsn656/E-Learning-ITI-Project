using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDBContext context) : base(context)
        { }

        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await context.Comments.Include(c => c.Post).Include(c=>c.CommentLikes).Include(c=>c.User).ToListAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await context.Comments.Where(p => p.Id == id).Include(c => c.CommentLikes).Include(p => p.Post).Include(c => c.User).SingleAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentByPostId(int id)
        {
            return await context.Comments.Where(p => p.PostId == id).Include(c=>c.CommentLikes).Include(p => p.Post).Include(c => c.User).ToListAsync();
        }
    }
}
