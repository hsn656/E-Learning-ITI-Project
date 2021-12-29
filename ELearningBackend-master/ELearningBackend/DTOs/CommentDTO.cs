using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }

        public int CommentLikes { get; set; }

        public string[] CommentLikesArr { get; set; }
        public string[] CommentDisLikesArr { get; set; }

    }
}
