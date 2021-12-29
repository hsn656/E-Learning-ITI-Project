using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class LessonComment
    {
        [ForeignKey("Lesson")]
        public int LessonId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public Lesson Lesson { get; set; } 
        public ApplicationUser User { get; set; } 
    }
}
