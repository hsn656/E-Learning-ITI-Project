using ELearningBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class QuestionRepository: Repository<Question>,IQuestionRepository
    {
        public QuestionRepository(ApplicationDBContext context):base(context)
        {

        }

        public new async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await context.Questions.Include(q => q.options)
                .Include(q=>q.Topics)
                .ToListAsync();
        }

        public async Task<IEnumerable<Question>> GetByTopicAsync(int TopicId)
        {
            var topic = await context.Topics.FindAsync(TopicId);
            return await context.Questions.Where(q => q.Topics.Contains(topic)).Include(q => q.options).ToListAsync();
        }

        public async Task<IEnumerable<Question>> GetRelatedAsync(int QstnId)
        {
            var question = await context.Questions.FindAsync(QstnId);
            var topics = await context.Topics.Where(t => t.Questions.Contains(question)).ToListAsync();

            List<Question> questions=new List<Question>();

            foreach (var topic in topics)
            {
                if (questions.Count >= 5)
                    break;
                var range = await context.Questions.Where(q => q.Topics.Contains(topic)).Include(q => q.options).ToListAsync();
                questions.AddRange(range.FindAll(x => {
                    return !questions.Contains(x) && x.Id != QstnId;
                }));
            }

            return questions;
        }

    }
}
