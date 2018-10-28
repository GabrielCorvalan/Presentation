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
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
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
        //    using (IDocumentStore ds = new DocumentStore { Urls = new[] { "http://localhost:8080" } }.Initialize())
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
