using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories.SqlRepositories
{
    public class ProjectSqlRepository : IProjectRepository
    {

        private readonly CodingLlamasDbContext _dbContext;

        public ProjectSqlRepository(CodingLlamasDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Project>> GetAllProjects()
        {
            return _dbContext.Projects.ToListAsync();
        }

        public Project GetProjectById(Guid id)
        {
            return _dbContext.Projects.Find(id);
        }

        public void Insert(Project project)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
