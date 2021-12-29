using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public interface IExamRepository:IRepository<Exam>
    {
        Task<Exam> GetFullExamAsync(int courseId);
    }
}
