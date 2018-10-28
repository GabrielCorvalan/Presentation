using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CouchDB.Bussiness.Services.Interfaces;

namespace CouchDB.WebApi.Controllers
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
        public IActionResult GetAll()
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
        public IActionResult GetById(int id)
        {
            try
            {
                var Student = studentService.GetStudentById(new Guid());

                return Ok(Student);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}