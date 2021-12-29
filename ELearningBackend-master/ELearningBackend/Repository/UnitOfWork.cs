using ELearningBackend.Models;
using ELearningBackend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private IExamRepository _exams;
        private IQuestionRepository _questions;
        private IVideoRepository _videos;
        private ITopicRepository _topics;
        private IPostRepository _posts;
        private ICommentRepository _comments;
        private IPostLikeRepository _postLike;
        private ICommentLikesRepository _commentLikes;
        private ICommentDisLikeRepository _commentDisLikes;

        private ICourse _courses;
        private IArticleRepository _articles;
        private IPostDisLikeRepository _postDisLike;
        private IUserRepository _users;
        private ILessonComment _lessonComment;


        public IQuestionRepository Questions
        {
            get
            {
                if (_questions is null)
                    _questions = new QuestionRepository(_context);
                return _questions;
            }
        }
        public IExamRepository Exams
        {
            get
            {
                if (_exams is null)
                    _exams = new ExamRepository(_context);
                return _exams;
            }
        }
        public IVideoRepository Videos
        {
            get
            {
                if (_videos is null)
                    _videos = new VideoRepository(_context);
                return _videos;
            }
        }

        public ITopicRepository Topics
        {
            get
            {
                if (_topics is null)
                    _topics = new TopicRepository(_context);
                return _topics;
            }
        }

        public IPostLikeRepository PostLikes
        {
            get
            {
                if (_postLike is null)
                    _postLike = new PostLikeRepository(_context);
                return _postLike;
            }
        }

        public IPostRepository Posts
        {
            get
            {
                if (_posts is null)
                    _posts = new PostRepository(_context);
                return _posts;
            }
        }

        public ICommentRepository Comments
        {
            get
            {
                if (_comments is null)
                    _comments = new CommentRepository(_context);
                return _comments;
            }
        }

        public ILessonComment LessonComment
        {
            get
            {
                if (_lessonComment is null)
                    _lessonComment = new LessonCommentRepository(_context);

                return _lessonComment;
            }
        }

        public ICommentLikesRepository CommentLikes
        {
            get
            {
                if (_commentLikes is null)
                    _commentLikes = new CommentLikesRepository(_context);
                return _commentLikes;
            }
        }
        public ICourse Courses
        {
            get
            {
                if (_courses is null)
                    _courses = new CourseRepository(_context);
                return _courses;
            }
        }

        public IArticleRepository Articles { 
            get
            {
                if (_articles is null)
                    _articles = new ArticleRepository(_context);
                return _articles;
            }
        }

        public IPostDisLikeRepository PostDisLike
        {
            get
            {
                if (_postDisLike is null)
                    _postDisLike = new PostDisLikeRepository(_context);
                return _postDisLike;
            }
        }

        public ICommentDisLikeRepository CommentDisLikes
        {
            get
            {
                if (_commentDisLikes is null)
                    _commentDisLikes = new CommentDisLikeRepository(_context);
                return _commentDisLikes;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_users is null)
                    _users = new UserRepository(_context);
                return _users;
            }
        }

        private ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
