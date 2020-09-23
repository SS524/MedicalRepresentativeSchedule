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
    

          [HttpGet("{date}")]
        public IActionResult Get(DateTime date)
        {
            
            try
            {
                if (date != null)
                {
                    string token = HttpContext.Request.Headers["Authorization"].FirstOrDefault().Split(" ")[1];
                    _log4net.Info(nameof(RepScheduleController)+" Http GET request using Date");

                    return Ok(_con.GetByDate(date,token));
                }
                else
                {
                    _log4net.Info(nameof(RepScheduleController)+"Date is null");
                    return BadRequest("Null Parameter can not  be expected");
                }
            }
            catch(Exception e)
            {    
                _log4net.Error(nameof(RepScheduleController)+"Exception"+e.Message);
                return StatusCode(500);
            }
        }

    }
}
