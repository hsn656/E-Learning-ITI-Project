using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        [JsonIgnore]
        public Post Post { get; set; }


        public ICollection<CommentLike> CommentLikes { get; set; } = new HashSet<CommentLike>();

        //[JsonIgnore]
        public ICollection<CommentDisLike> CommentDisLikes { get; set; } = new HashSet<CommentDisLike>();

    }
}
