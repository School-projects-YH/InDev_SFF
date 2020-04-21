using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFF.Datasource.Repository;
using SFF.Datasource.Context;


namespace SFF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieStudioController : ControllerBase
    {
        // GET: api/MovieStudio
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MovieStudio/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MovieStudio
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MovieStudio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
