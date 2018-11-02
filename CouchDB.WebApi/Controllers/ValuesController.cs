using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CouchDB.WebApi.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{Id}")]
        public ActionResult<string> Get(int Id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{Id}")]
        public void Put(int Id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
        }

        //[HttpPost]
        //public ActionResult Post()
        //{
        //    using (var ds = new DocumentStore { Urls = new[] { "http://127.0.0.1:8080" }  }.Initialize())
        //    {
        //        using (var session = ds.OpenSession("Presentation"))
        //        {
                    
        //        }
        //    }
        //    return Ok("Congratulations !!");
        //}

        //[HttpGet]
        //public IList GetNames()
        //{
        //    IList users = new List<User>();
        //    using (IdocumentStore ds = new DocumentStore { Urls = new[] { "http://localhost:8080" } }.Initialize())
        //    {
        //        using (var session = ds.OpenSession("db_home"))
        //        {
        //            users = (from user in session.Query<User>()
        //                     select user).ToList();
        //        }
        //    }
        //    return users;
        //}
    }
}
