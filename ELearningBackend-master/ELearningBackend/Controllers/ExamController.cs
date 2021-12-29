using AutoMapper;
using ELearningBackend.DTOs;
using ELearningBackend.Models;
using ELearningBackend.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExamController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet("allQuestions")]
        public async Task<ActionResult<IEnumerable<QuestionDTO>>> GetAllQuestionsAsync()
        {
            return Ok(_mapper.Map<IEnumerable<QuestionDTO>>(await _unitOfWork.Questions.GetAllAsync()));
            //return Ok(await _unitOfWork.Questions.GetAllAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExamsAsync([FromRoute] int id)
        {
            return Ok(await _unitOfWork.Exams.GetFullExamAsync(id));
        }

        [HttpGet("Topic/{QstnId}")]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestionsByTopicAsync([FromRoute] int QstnId)
        {
            return Ok(await _unitOfWork.Questions.GetRelatedAsync(QstnId));
        }

        [HttpPost]
        public async Task<ActionResult> AddExamAsync(Exam exam)
        {
            await _unitOfWork.Exams.AddAsync(exam);
            await _unitOfWork.SaveAsync();
            return Ok(exam);
        }
        [HttpPut]
        public async Task<IActionResult> EditExamAsync(Exam exam)
        {
            _unitOfWork.Exams.Update(exam);
            await _unitOfWork.SaveAsync();
            return Ok(exam);
        }
    }
}
