using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Presentation.Bussiness.Interfaces;
using Presentation.Entities.Models;

namespace Presentation.WebApi.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService service)
        {
            userService = service;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                return Ok(userService.GetUserById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                var user = userService.GetUserById(Id);

                return Ok(userService.Delete(user));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        [Produces("application/json", Type = typeof(bool))]
        public IActionResult Post([FromBody]UserDTO user)
        {
            try
            {
                return Ok(userService.CreateOrUpdate(user));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}