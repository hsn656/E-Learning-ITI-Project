using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<IEnumerable<Post>> GetPostsWithLimit(int id);
        Task<Post> GetPostById(int id);
        Post SimpleFind(int id);
    }
}
