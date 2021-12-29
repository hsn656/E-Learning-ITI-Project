using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface ILessonComment
    {
        Task<IEnumerable<LessonComment>> GetAllCommentsBylsnId(int id);
        void AddAsync(LessonComment entity);

    }
}
