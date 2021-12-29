using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public class ApplicationDBContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public  DbSet<Exam> Exams { get; set; }
        public  DbSet<Question> Questions { get; set; }
        public  DbSet<Option> Options { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostLike> Likes { get; set; }
        public DbSet<PostDisLike> DisLikes { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }
        public DbSet<CommentDisLike> CommentDisLikes { get; set; }
        public DbSet<LessonComment> lessonComment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            #region Lesson Config
            builder.Entity<Video>().HasBaseType<Lesson>();
             builder.Entity<Article>().HasBaseType<Lesson>();
            builder.Entity<Lesson>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");
            #endregion

            #region Lesson Comments Config

            builder.Entity<LessonComment>().HasKey(C => new { C.LessonId, C.UserId,C.CreatedAt });
            builder.Entity<LessonComment>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");

            #endregion


            #region Course Config

            builder.Entity<Course>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");

            #endregion

            #region Exam Config
            builder.Entity<Exam>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");
            #endregion

            #region Question Config
            builder.Entity<Question>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");
            #endregion

            #region Post Config
            builder.Entity<Post>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<Post>().Property(c => c.Views).HasDefaultValue(0);
            #endregion

            #region Post Comments Config

            builder.Entity<Comment>().Property(c => c.CreatedAt).HasDefaultValueSql("getdate()");

            #endregion

            #region Post Likes
            builder.Entity<PostLike>().HasKey(L => new { L.PostId, L.UserId });
            #endregion



            #region Post DisLikes
            builder.Entity<PostDisLike>().HasKey(D => new { D.PostId, D.UserId });
            #endregion

            #region comment Likes
            builder.Entity<CommentLike>().HasKey(L => new { L.CommentId, L.UserId });
            #endregion



            #region comment DisLikes
            builder.Entity<CommentDisLike>().HasKey(D => new { D.CommentId, D.UserId });
            #endregion

            builder.Entity<PostLike>().ToTable("PostLike");
            builder.Entity<CommentLike>().ToTable("CommentLike");
            builder.Entity<CommentDisLike>().ToTable("CommentDisLike");
            builder.Entity<PostDisLike>().ToTable("PostDisLike");

            base.OnModelCreating(builder); 
           
        }

    }
}
