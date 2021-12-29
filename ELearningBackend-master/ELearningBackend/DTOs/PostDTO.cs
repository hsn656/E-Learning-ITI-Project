using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }
        public DateTime? CreatedAt { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public int PostLikes { get; set; }
        public int CommentsCount { get; set; }

        public string[] PostLikesArr { get; set; }
        public string[] PostDisLikesArr { get; set; }

    }


    public class PostCommentsDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }
        public DateTime? CreatedAt { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public int PostLikes { get; set; }
        public string[] PostLikesArr { get; set; }
        public string[] PostDisLikesArr { get; set; }

        
        public ICollection<CommentDTO> Comments { get; set; }

    }
}
