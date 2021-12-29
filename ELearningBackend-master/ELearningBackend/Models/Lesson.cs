using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public abstract class Lesson
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

        public DateTime? CreatedAt { get; set; }

        [JsonIgnore]
        public ICollection<LessonComment> Comments { get; set; } = new HashSet<LessonComment>(); 
    }
}
