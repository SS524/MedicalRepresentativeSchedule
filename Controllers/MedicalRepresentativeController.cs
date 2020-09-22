using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalRepresentativeScheduleMicroservice.Models;
using MedicalRepresentativeScheduleMicroservice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalRepresentativeScheduleMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRepresentativeController : ControllerBase
    {
        // GET: api/MedicalRepresentative
        [HttpGet]
        public IEnumerable<MedicalRepresentative> Get()
        {
            return MedicalRepresentativeRepository.ls;
        }

        // GET: api/MedicalRepresentative/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/MedicalRepresentative
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/MedicalRepresentative/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
       
    }
}
