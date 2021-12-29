using AutoMapper;
using ELearningBackend.DTOs;
using ELearningBackend.Models;
using ELearningBackend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ELearningBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonCommentController : ControllerBase
    {

        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHubContext<BroadcastHub, IHubClient> hubContext;

        public LessonCommentController(IMapper mapper, IUnitOfWork unitOfWork, IHubContext<BroadcastHub, IHubClient> _hubContext)
        {
            _unitOfWork = unitOfWork;
            hubContext = _hubContext;
            _mapper = mapper;
        }


        // GET: api/<LessonCommentController>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<LessonCommentDTO>>> GetAll(int id)
        {
            try
            {
                var Comments = await _unitOfWork.LessonComment.GetAllCommentsBylsnId(id);
                return Ok(_mapper.Map<IEnumerable<LessonCommentDTO>>(Comments));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //// GET api/<LessonCommentController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<LessonCommentController>

        [HttpPost]
        public async Task<ActionResult> Comment(LessonComment comment)
        {
             _unitOfWork.LessonComment.AddAsync(comment);
             _unitOfWork.SaveChanges();
            await hubContext.Clients.All.comment();

            return Ok();
        }

        //// PUT api/<LessonCommentController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<LessonCommentController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
