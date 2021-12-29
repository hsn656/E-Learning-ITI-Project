using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public DateTime? CreatedAt { get; set; }

        [JsonIgnore]
        public  ICollection<Exam> Exams { get; set; } = new HashSet<Exam>();

        public ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();

        public  ICollection<Option> options { get; set; } = new HashSet<Option>();
    }
}
