using ELearningBackend.Models;
using ELearningBackend.Repository;
using ELearningBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ELearningBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IAuthService _authService;
        private readonly IUnitOfWork _unitOfWork;
        public AuthController(IUnitOfWork unitOfWork, IAuthService authService, IWebHostEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthinticated)
                return BadRequest(result.Message);

            return Ok(result);
        }


        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(TokentRequesModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.GetTokenAsync(model);

            if (!result.IsAuthinticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.ChangePasswordAsync(model);

            if (!result)
                return BadRequest("كلمة المرور تضمن ارقام وحروف ورموز لجعلها أقوي من ان تُخترق. كما انه يجب ان تُدخل كلمة المرور الصحيحة التي تستخدمها لتسجيل الدخول");

            return Ok();
        }

        [HttpPost("changeEmail")]
        public async Task<IActionResult> ChangeEmailAsync(ChangeEmailModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("برجاء ارسال البريد الالكتروني بالطريقة الصحيحة");

            var result = await _authService.ChangeEmaildAsync(model);

            if (!result)
                return BadRequest("يجب عليك ادخال بريد الكتروني صالح");

            return Ok();
        }

        [HttpPost("Image/{id}"), DisableRequestSizeLimit]
        public async Task<ActionResult> Upload([FromRoute] string id)
        {
            try
            {
                var file = Request.Form.Files[0];
                string folderName = "Resources";
                string webRootPath = _hostingEnvironment.WebRootPath;
                string newPath = Path.Combine(webRootPath, folderName);

                if (file.Length > 0)
                {
                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string fileExtension = Path.GetExtension(fileName).ToLower();
                    if(fileExtension==".jpg"|| fileExtension == ".png")
                    {
                        string fullPath = Path.Combine(newPath, "User"+id+ fileExtension);
                        var dbPath = Path.Combine(folderName, "User" + id + fileExtension);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        var data = await _unitOfWork.Users.GetByIdAsync(id);
                        data.Image = dbPath;
                        await _unitOfWork.SaveAsync();

                        return Ok(new { dbPath });
                    }
                }
                return BadRequest("هناك خطأ في صيغة الملف المراد تحميله");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
