using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface ICommentDisLikeRepository: IRepository<CommentDisLike>
    {
        Task<CommentDisLike> FindInCommentDisLike(int id, string userId);
    }
}
