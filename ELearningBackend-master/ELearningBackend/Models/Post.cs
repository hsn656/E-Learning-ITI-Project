using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }

        public DateTime? CreatedAt { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
    
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        //[JsonIgnore]
        public ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>();
        [JsonIgnore]
        public ICollection<PostDisLike> PostDisLikes { get; set; } = new HashSet<PostDisLike>();



    }
}
