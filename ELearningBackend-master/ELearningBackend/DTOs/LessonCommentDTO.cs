using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.DTOs
{
    public class LessonCommentDTO
    {
        public string Content { get; set; }
        public string Image { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LessonName { get; set; }
        public int Id { get; set; }

    }
}
