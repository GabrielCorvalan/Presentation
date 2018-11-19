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
    public class PageController : ControllerBase
    {
        private readonly IPageService pageService;

        public PageController(IPageService service)
        {
            pageService = service;
        }

        [HttpGet]
        public IActionResult GetAllPages()
        {
            try
            {
                return Ok(pageService.GetAllPages());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPageById(int id)
        {
            try
            {
                return Ok(pageService.GetPageById(id));
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
                var page = pageService.GetPageById(Id);

                return Ok(pageService.Delete(page));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        [Produces("application/json", Type = typeof(bool))]
        public IActionResult Post([FromBody]PageDTO page)
        {
            try
            {
                return Ok(pageService.CreateOrUpdate(page));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}