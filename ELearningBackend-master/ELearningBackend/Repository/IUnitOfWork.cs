using ELearningBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IExamRepository Exams { get; }
        IQuestionRepository Questions { get; }
        IVideoRepository Videos { get; }
        ITopicRepository Topics { get; }
        ICourse Courses { get; }
        IArticleRepository Articles { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        IPostLikeRepository PostLikes { get; }
        ICommentLikesRepository CommentLikes { get; }
        ICommentDisLikeRepository CommentDisLikes { get; }
        IPostDisLikeRepository PostDisLike { get; }
        IUserRepository Users { get; }
        ILessonComment LessonComment { get; }

        Task SaveAsync();
        void SaveChanges();
    }
}
