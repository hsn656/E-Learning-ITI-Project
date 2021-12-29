using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class CommentLike
    {
        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        [JsonIgnore]
        public Comment Comment { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
    }
}
