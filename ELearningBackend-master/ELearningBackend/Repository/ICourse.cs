using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface ICourse
    {
        Task<Course> GetCourseByIdAsync(int CourseId);
        Task<IEnumerable<Course>> GetSomeCoursesAsync();
        Task<IEnumerable<Course>> GetCoursesAsync();

    }
}
