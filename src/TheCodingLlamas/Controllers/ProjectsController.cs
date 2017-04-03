using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCodingLlamas.Models;
using TheCodingLlamas.Repositories;

namespace TheCodingLlamas.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Project>> Get()
        {
            return await _projectRepository.GetAllProjects();
        }

        // GET api/getproject/5
        [HttpGet("{id}", Name = "GetProject")]
        public IActionResult Get(string id)
        {
            var project = _projectRepository.GetProjectById(Guid.Parse(id));

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

    }
}