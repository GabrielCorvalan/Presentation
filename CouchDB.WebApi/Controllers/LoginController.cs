using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Presentation.Bussiness.Interfaces;
using System;

namespace Presentation.WebApi.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService service)
        {
            loginService = service;
        }

        [HttpGet("AuthLogin/{username}/{password}")]
        public IActionResult GetStudentById(string username, string password)
        {
            try
            {
                return Ok(loginService.GetUserLogin(username, password));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}