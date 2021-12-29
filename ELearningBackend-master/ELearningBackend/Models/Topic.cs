using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearNo { get; set; }
        public int UnitNo { get; set; }
        public int LessonNo { get; set; }
        public ICollection<Video> Videos { get; set; } = new HashSet<Video>();
        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();
        [JsonIgnore]
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();
    }
}
