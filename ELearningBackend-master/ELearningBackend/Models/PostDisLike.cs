using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class PostDisLike
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public Post Post { get; set; }
        public ApplicationUser User { get; set; }
    }
}
