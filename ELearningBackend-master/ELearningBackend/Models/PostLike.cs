using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class PostLike
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        [JsonIgnore]
        public Post Post { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
    }
}
