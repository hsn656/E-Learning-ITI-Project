using AutoMapper;
using ELearningBackend.Models;
using ELearningBackend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ELearningBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHubContext<BroadcastHub, IHubClient> hubContext;

        public CommentController(IUnitOfWork unitOfWork, IMapper mapper, IHubContext<BroadcastHub, IHubClient> _hubContext)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            hubContext = _hubContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAll()
        {
            return Ok(await _unitOfWork.Comments.GetAllComments());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetCommentById([FromRoute] int id)
        {
            return Ok(await _unitOfWork.Comments.GetCommentById(id));
        }

        [HttpGet("getByPost/{id}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetCommentByPostId([FromRoute] int id)
        {
            return Ok(await _unitOfWork.Comments.GetCommentByPostId(id));
        }



        [HttpPost]
        public async Task<ActionResult> AddComment(Comment _comment)
        {
            await _unitOfWork.Comments.AddAsync(_comment);
            await _unitOfWork.SaveAsync();
            await hubContext.Clients.All.broadcast();

            return Ok();
        }


        [HttpPost("like/{id}")]
        public async Task<ActionResult> EditReactionLike([FromRoute] int id, [FromBody] CommentLike _comment)
        {
            var recordInLike = await _unitOfWork.CommentLikes.FindInCommentLike(id, _comment.UserId);
            if (recordInLike == null)
            {
                await _unitOfWork.CommentLikes.AddAsync(_comment);
                await _unitOfWork.SaveAsync();
                //await hubContext.Clients.All.broadcast();

            }

            var data = await _unitOfWork.CommentDisLikes.FindInCommentDisLike(id, _comment.UserId);
            if (data != null)
            {
                _unitOfWork.CommentDisLikes.Remove(data);
                _unitOfWork.SaveChanges();

            }
            await hubContext.Clients.All.broadcast();
            return Ok();

            //var data = _unitOfWork.CommentLikes.FindInCommentLike(id, _comment.UserId);
            //if (!data)
            //{
            //    _unitOfWork.CommentLikes.Add(_comment);
            //    _unitOfWork.SaveChanges();
            //    return Ok();
            //}
            //return BadRequest();
        }


        [HttpPost("dislike/{id}")]
        public async Task<ActionResult> EditReactionDisLike([FromRoute] int id, [FromBody] CommentDisLike _comment)
        {
            var recordInDisLike = await _unitOfWork.CommentDisLikes.FindInCommentDisLike(id, _comment.UserId);
            if (recordInDisLike == null)
            {
                await _unitOfWork.CommentDisLikes.AddAsync(_comment);
                await _unitOfWork.SaveAsync();
                //await hubContext.Clients.All.broadcast();

            }

            var data = await _unitOfWork.CommentLikes.FindInCommentLike(id, _comment.UserId);
            if (data != null)
            {
                _unitOfWork.CommentLikes.Remove(data);
                _unitOfWork.SaveChanges();

            }
            await hubContext.Clients.All.broadcast();
            return Ok();



            //var data = _unitOfWork.CommentLikes.FindInCommentLike(id, _comment.UserId);
            //if (data)
            //{
            //    _unitOfWork.CommentLikes.Remove(_comment);
            //    _unitOfWork.SaveChanges();
            //    return Ok();
            //}
            //return BadRequest();
        }
    }
}
