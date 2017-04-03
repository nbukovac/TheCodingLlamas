using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCodingLlamas.Models;
using TheCodingLlamas.Repositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheCodingLlamas.Controllers
{
    [Route("api/[controller]")]
    public class TechnologiesController : Controller
    {

        private readonly ITechnologyRepository _technologyRepository;

        public TechnologiesController(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Technology>> Get()
        {
            return await _technologyRepository.GetAllTechnologies();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
