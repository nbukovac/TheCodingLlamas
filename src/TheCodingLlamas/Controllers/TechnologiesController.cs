using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCodingLlamas.Models;
using TheCodingLlamas.Repositories;


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

        // GET api/gettechnology/5
        [HttpGet("{id}", Name = "GetTechnology")]
        public IActionResult Get(string id)
        {
            var technology = _technologyRepository.GetTechnologyById(Guid.Parse(id));

            if (technology == null)
            {
                return NotFound();
            }

            return Ok(technology);
        }

    }
}