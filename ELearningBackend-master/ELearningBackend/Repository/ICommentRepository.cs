using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment> GetCommentById(int id);
        Task<IEnumerable<Comment>> GetCommentByPostId(int id);
    }
}
