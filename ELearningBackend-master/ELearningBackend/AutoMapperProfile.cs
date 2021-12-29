using AutoMapper;
using ELearningBackend.DTOs;
using ELearningBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDTO>()
                .ForPath(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForPath(dest => dest.Image, opt => opt.MapFrom(src => src.User.Image))
                .ForPath(dest => dest.PostLikes, opt => opt.MapFrom(src => src.PostLikes.Count))
                .ForPath(dest => dest.PostLikesArr, opt => opt.MapFrom(src => src.PostLikes.Select(p=>p.UserId)))
                .ForPath(dest => dest.PostDisLikesArr, opt => opt.MapFrom(src => src.PostDisLikes.Select(p=>p.UserId)))
                .ForPath(dest => dest.CommentsCount, opt => opt.MapFrom(src => src.Comments.Count));

            CreateMap<Post, PostCommentsDTO>()
                .ForPath(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForPath(dest => dest.Image, opt => opt.MapFrom(src => src.User.Image))
                .ForPath(dest => dest.PostLikes, opt => opt.MapFrom(src => src.PostLikes.Count))
                .ForPath(dest => dest.PostLikesArr, opt => opt.MapFrom(src => src.PostLikes.Select(p => p.UserId)))
                .ForPath(dest => dest.PostDisLikesArr, opt => opt.MapFrom(src => src.PostDisLikes.Select(p => p.UserId)));


            CreateMap<Comment, CommentDTO>()
                .ForPath(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForPath(dest => dest.Image, opt => opt.MapFrom(src => src.User.Image))
                .ForPath(dest => dest.CommentLikes, opt => opt.MapFrom(src => src.CommentLikes.Count))
                .ForPath(dest => dest.CommentLikesArr, opt => opt.MapFrom(src => src.CommentLikes.Select(p => p.UserId)))
                .ForPath(dest => dest.CommentDisLikesArr, opt => opt.MapFrom(src => src.CommentDisLikes.Select(p => p.UserId)));
            /////////////////////////////////////////////////

            CreateMap<Question, QuestionDTO>()
                .ForPath(dest => dest.TopicId, opt => opt.MapFrom(src => src.Topics.Select(t => t.Id)));

            CreateMap<Option, OptionsDTO>();
            CreateMap<Topic, TopicDTO>();

            CreateMap<LessonComment, LessonCommentDTO>()
                .ForPath(dest => dest.Content, cmnt => cmnt.MapFrom(src => src.Content))
                .ForPath(dest => dest.CreatedAt, cmnt => cmnt.MapFrom(src => src.CreatedAt))
                .ForPath(dest => dest.LessonName, cmnt => cmnt.MapFrom(src => src.Lesson.Title))
                .ForPath(dest => dest.UserName, cmnt => cmnt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
                .ForPath(dest => dest.Id, cmnt => cmnt.MapFrom(src => src.LessonId))
                .ForPath(dest => dest.Image, cmnt => cmnt.MapFrom(src => src.User.Image));
        }
    }
}
