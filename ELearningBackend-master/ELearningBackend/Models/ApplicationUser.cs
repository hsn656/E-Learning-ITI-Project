using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public string Image { get; set; }


        [JsonIgnore]
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<Video> WatchedVideos { get; set; } = new HashSet<Video>();
        [JsonIgnore]
        public ICollection<LessonComment> Comments { get; set; } = new HashSet<LessonComment>();    
        [JsonIgnore]
        public ICollection<PostLike> LikedPosts { get; set; } = new HashSet<PostLike>();
        [JsonIgnore]
        public ICollection<PostDisLike> DisLikedPosts { get; set; } = new HashSet<PostDisLike>();
        [JsonIgnore]
        public ICollection<CommentLike> LikedComments { get; set; } = new HashSet<CommentLike>();
        [JsonIgnore]
        public ICollection<CommentDisLike> DisLikedComments { get; set; } = new HashSet<CommentDisLike>();


    }
}
