using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCodingLlamas.Models;
using TheCodingLlamas.Repositories;


namespace TheCodingLlamas.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return await _personRepository.GetAllPersons();
        }

        // GET api/getperson/5
        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult Get(string id)
        {
            var person = _personRepository.GetById(Guid.Parse(id));

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}