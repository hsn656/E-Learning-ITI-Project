using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Video:Lesson
    {
        public string Link { get; set; }
        public int? Order { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }

        [JsonIgnore]
        public Course Course { get; set; }

        [JsonIgnore]
        public ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();

        [JsonIgnore]
        public ICollection<ApplicationUser> Watchers { get; set; } = new HashSet<ApplicationUser>();
    }
}
