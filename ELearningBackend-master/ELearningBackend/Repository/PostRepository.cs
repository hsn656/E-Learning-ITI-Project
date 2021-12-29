using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDBContext context) : base(context)
        { }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            //return await context.Posts.Include(p => p.Comments).ThenInclude(c=>c.CommentLikes).Include(p=>p.PostLikes).Include(p=>p.User).ToListAsync();
            return await context.Posts.Include(p=>p.User).Include(p => p.Comments).Include(p => p.PostLikes).Include(p => p.PostDisLikes).OrderByDescending(p=>p.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetPostsWithLimit(int id)
        {
            //return await context.Posts.Include(p => p.Comments).ThenInclude(c=>c.CommentLikes).Include(p=>p.PostLikes).Include(p=>p.User).ToListAsync();
            return await context.Posts.Include(p => p.User).Include(p => p.Comments).Include(p => p.PostLikes).Include(p => p.PostDisLikes).Where(p=>p.Id!=id).Take(4).ToListAsync();
        }


        public async Task<Post> GetPostById(int id)
        {
            return await context.Posts.Where(p=>p.Id==id)
                .Include(p=>p.User)
                .Include(p => p.PostLikes).Include(p => p.PostDisLikes)
                .Include(p => p.Comments)
                .ThenInclude(c => c.CommentLikes)
                .Include(p=>p.Comments)
                .ThenInclude(c=>c.CommentDisLikes)
                .Include(p => p.Comments)
                .ThenInclude(c => c.User)
                .SingleAsync();
        }

        public Post SimpleFind(int id)
        {
            return context.Posts.Find(id);
        }
    }
}
