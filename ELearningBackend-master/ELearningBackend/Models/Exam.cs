using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }

        [JsonIgnore]
        public Course Course { get; set; }
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>(); 
    }
}
