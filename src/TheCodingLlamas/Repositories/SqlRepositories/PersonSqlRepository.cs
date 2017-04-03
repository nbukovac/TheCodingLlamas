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
            var milicic = new Person("Nikola", "Miličić", 4, "Fakultet elektrotehnike i računarstva",
                "https://www.linkedin.com/in/nikola-miličić-33bab263/", "https://github.com/NMilicic",
                "", "", 
                "Nikola is our C# master, but he can work magic with pretty much anything you throw his way.",
                "C# guru",
                "assets/images/milicic.jpg");
            milicic.Technologies.AddRange(new List<Technology>()
            {
                new Technology(".*Script"),
                new Technology("C#"),
                new Technology("Bash")
            });
            milicic.Projects.AddRange(new List<Project>());
            Insert(milicic);

            var vrbanec = new Person("Brigita", "Vrbanec", 4, "Fakultet elektrotehnike i računarstva",
                "https://www.linkedin.com/in/bvrbanec/", "https://github.com/bvrbanec",
                "", "", "Brigita is the mastermind behind our projects but can also produce code if needed.",
                "Evil mastermind", "assets/images/vrbanec.jpg");
            vrbanec.Technologies.AddRange(new List<Technology>()
            {
                new Technology("C#"),
                new Technology("Bash"),
                new Technology("PHP"),
                new Technology("Swift")
            });
            vrbanec.Projects.AddRange(new List<Project>());
            Insert(vrbanec);

            var bukovac = new Person("Nikola", "Bukovac", 4,
                "Fakultet elektrotehnike i računarstva", "https://www.linkedin.com/in/nikola-bukovac-ab017b120/",
                "https://github.com/nbukovac", "nikola.bukovac@outlook.com",
                "+385912371969",
                "Nikola pulls classes and methods out of his sleeve and can easily turn any idea into code.",
                "Code monkey", "assets/images/bukovac.jpg");
            bukovac.Technologies.AddRange(new List<Technology>()
            {
                new Technology("C#"),
                new Technology("Java"),
                new Technology("Bash"),
                new Technology("Python"),
                new Technology("Swift"),
                new Technology("C++")
            });
            bukovac.Projects.AddRange(new List<Project>());
            Insert(bukovac);
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
