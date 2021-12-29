using AutoMapper;
using ELearningBackend.DTOs;
using ELearningBackend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TopicController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicDTO>>> GetAllQuestionsTopicsAsync()
        {
            return Ok(_mapper.Map<IEnumerable<TopicDTO>>(await _unitOfWork.Topics.GetAllAsync()));
        }

    }
}
