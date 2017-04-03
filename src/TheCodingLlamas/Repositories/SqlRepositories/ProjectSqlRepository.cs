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

            if (!_dbContext.Projects.Any())
            {
                Seeder.SeedData(dbContext);
            }
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
            _dbContext.Add(project);
            _dbContext.SaveChanges();
        }

        public void Update(Project project)
        {
            _dbContext.Entry(project).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Guid projectId)
        {
            _dbContext.Projects.Remove(GetProjectById(projectId));
            _dbContext.SaveChanges();
        }
    }
}