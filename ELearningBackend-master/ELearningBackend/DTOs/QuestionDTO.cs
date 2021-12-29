using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int[] TopicId { get; set; }

        public ICollection<OptionsDTO> options { get; set; }
    }
}
