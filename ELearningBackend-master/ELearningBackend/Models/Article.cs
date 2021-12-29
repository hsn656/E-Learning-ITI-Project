using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Article:Lesson
    {
        public string Content { get; set; }
        public string Discription { get; set; }
        [JsonIgnore]
        public ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();


    }
}
