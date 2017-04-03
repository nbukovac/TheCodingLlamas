using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories.SqlRepositories
{
    public class TechnologySqlRepository : ITechnologyRepository
    {
        private readonly CodingLlamasDbContext _dbContext;

        public TechnologySqlRepository(CodingLlamasDbContext dbContext)
        {
            _dbContext = dbContext;
            Seed();
        }

        public Task<List<Technology>> GetAllTechnologies()
        {
            return _dbContext.Technologies.ToListAsync();
        }

        public Technology GetTechnologyById(Guid id)
        {
            return _dbContext.Technologies.Find(id);
        }

        public void Insert(Technology model)
        {
            _dbContext.Technologies.Add(model);
            _dbContext.SaveChanges();
        }

        public void Update(Technology technology)
        {
            _dbContext.Entry(technology).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _dbContext.Technologies.Remove(GetTechnologyById(id));
            _dbContext.SaveChanges();
        }


        private void Seed()
        {
            Insert(new Technology("C#"));
            Insert(new Technology("Java"));
            Insert(new Technology("Python"));
            Insert(new Technology(".*Script"));
            Insert(new Technology("Swift"));
            Insert(new Technology("Bash"));
        }

    }
}
