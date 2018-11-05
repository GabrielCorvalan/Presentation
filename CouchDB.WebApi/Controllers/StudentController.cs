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
                var Students = studentService.GetAllStudents();

                return Ok(Students);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(string id)
        {
            try
            {
                var student = studentService.GetStudentById(id);

                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string Id)
        {
            try
            {
                var student = studentService.GetStudentById(Id);
                var response = studentService.Delete(student);

                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        [HttpPost]
        [Produces("application/json", Type = typeof(bool))]
        public IActionResult Post([FromBody]Student student)
        {
            try
            {
                var response = studentService.CreateOrUpdate(student);

                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}