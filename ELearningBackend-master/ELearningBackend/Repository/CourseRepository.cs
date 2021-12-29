using ELearningBackend.Models;
using ELearningBackend.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class CourseRepository:Repository<Course> , ICourse
    {
        public CourseRepository(ApplicationDBContext context):base(context)
        {
               
        }

        public async Task<Course> GetCourseByIdAsync(int CourseId)
        {
            return await context.Courses.Where(c => c.Id == CourseId).Include(c => c.Lessons).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await context.Courses.ToListAsync();
        }


        public async Task<IEnumerable<Course>> GetSomeCoursesAsync()
        {
            return await context.Courses.Take(4).ToListAsync();
        }
    }
}
