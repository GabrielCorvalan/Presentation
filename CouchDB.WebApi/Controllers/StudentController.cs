using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Bussiness.Services.Interfaces;
using Presentation.Entities.Models;

namespace Presentation.WebApi.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService service)
        {
            studentService = service;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            try
            {
                return Ok(studentService.GetAllStudents());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                return Ok(studentService.GetStudentById(id));
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
                var student = studentService.GetStudentById(Id);

                return Ok(studentService.Delete(student));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        [HttpPost]
        [Produces("application/json", Type = typeof(bool))]
        public IActionResult Post([FromBody]StudentDTO student)
        {
            try
            {
                return Ok(studentService.CreateOrUpdate(student));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}