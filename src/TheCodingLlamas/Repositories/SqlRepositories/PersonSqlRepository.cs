using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories.SqlRepositories
{
    public class PersonSqlRepository : IPersonRepository
    {
        private readonly CodingLlamasDbContext _dbContext;

        public PersonSqlRepository(CodingLlamasDbContext dbContext)
        {
            _dbContext = dbContext;

            if (!_dbContext.Persons.Any())
            {
                Seeder.SeedData(dbContext);
            }
        }

        public Task<List<Person>> GetAllPersons()
        {
            return _dbContext.Persons.ToListAsync();
        }

        public Person GetById(Guid personId)
        {
            return _dbContext.Persons.Find(personId);
        }

        public void Insert(Person entity)
        {
            _dbContext.Persons.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Person entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Guid personId)
        {
            _dbContext.Persons.Remove(GetById(personId));
            _dbContext.SaveChanges();
        }
    }
}