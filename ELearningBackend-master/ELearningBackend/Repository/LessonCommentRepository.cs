using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class LessonCommentRepository : Repository<ILessonComment>, ILessonComment
    {
        public LessonCommentRepository(ApplicationDBContext context):base(context)
        {

        }

        public void AddAsync(LessonComment entity)
        {
            context.lessonComment.Add(entity);
            context.SaveChanges();
        }

        public async Task<IEnumerable<LessonComment>> GetAllCommentsBylsnId(int id)
        {
            return await context.lessonComment.Where(a=>a.LessonId==id).Include(l=>l.User).ToListAsync();
        }


    }
}
