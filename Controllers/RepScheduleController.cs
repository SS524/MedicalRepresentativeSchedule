using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalRepresentativeScheduleMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepScheduleController : ControllerBase
    {
        // GET: api/RepSchedule
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RepSchedule/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RepSchedule
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/RepSchedule/5
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
