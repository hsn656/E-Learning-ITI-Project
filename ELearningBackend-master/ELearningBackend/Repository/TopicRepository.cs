using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class TopicRepository:Repository<Topic>,ITopicRepository
    {
        public TopicRepository(ApplicationDBContext context):base(context)
        {

        }
    }
}
