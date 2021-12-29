using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class ExamRepository:Repository<Exam>,IExamRepository
    {

        public ExamRepository(ApplicationDBContext context):base(context)
        {

        }

        public async Task<Exam> GetFullExamAsync(int courseId)
        {
            return await context.Exams.Where(e=>e.CourseId==courseId).Include(e => e.Questions).ThenInclude(q => q.options).SingleOrDefaultAsync();
        }
       
    }
}
