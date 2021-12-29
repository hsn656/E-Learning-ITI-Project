using ELearningBackend.Models;
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
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUserAsync([FromRoute] string id)
        {
            return Ok(await _unitOfWork.Users.GetByIdAsync(id));
        }

        [HttpPut]
        public IActionResult UpdateUser(ApplicationUser user)
        {
            _unitOfWork.Users.Update(user);
            _unitOfWork.SaveChanges();
            return Ok();
        }

    }
}
