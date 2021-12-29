using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class CommentDisLike
    {
        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public Comment Comment { get; set; }
        public ApplicationUser User { get; set; }
    }
}
