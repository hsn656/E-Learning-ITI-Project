using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Course
    {
        public int Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }

        public int Order { get; set; }
        public Exam Exam { get; set; }
        public ICollection<Video> Lessons { get; set; } = new HashSet<Video>();

    }
}
