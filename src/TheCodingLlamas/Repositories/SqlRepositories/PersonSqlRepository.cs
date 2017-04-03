using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Emit;
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
            Seed();
        }

        private void Seed()
        {
            Insert(new Person("Nikola", "Bukovac", 4, 
                "Fakultet elektrotehnike i računarstva", "", 
                "https://github.com/nbukovac", "nikola.bukovac@outlook.com" , 
                "+385912371969", "bacc.ing.comp.", "code monkey", ""));
            Insert(new Person("Nikola", "Miličić", 4, "Fakultet elektrotehnike i računarstva",
                "", "", "", "", "", "bacc.ing.comp.", ""));
            Insert(new Person("Brigita", "Vrbanec", 4, "Fakultet elektrotehnike i računarstva",
                "", "", "", "", "bacc.ing.comp.", "", ""));
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
