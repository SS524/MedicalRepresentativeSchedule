using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalRepresentativeScheduleMicroservice.Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalRepresentativeScheduleMicroservice.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RepScheduleController : ControllerBase
    {
        readonly log4net.ILog _log4net;

        private readonly RepScheduleProvider _con;
        public RepScheduleController(RepScheduleProvider provider)
        {
            _log4net = log4net.LogManager.GetLogger(typeof(RepScheduleController));

            _con = provider;
        }
        // GET: api/RepSchedule
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/RepSchedule/5
        [HttpGet("{date}")]
        public IActionResult Get(DateTime date)
        {
            
            try
            {
                if (date != null)
                {
                    string token = HttpContext.Request.Headers["Authorization"].FirstOrDefault().Split(" ")[1];
                    _log4net.Info(" Http GET request");

                    return Ok(_con.GetByDate(date,token));
                }
                else
                {
                    return BadRequest("Null Parameter can not  be expected");
                }
            }
            catch(Exception)
            {
                _log4net.Error(" Internal Error Occured");
                return BadRequest();
            }
        }

        // POST: api/RepSchedule
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/RepSchedule/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

       
      
    }
}
