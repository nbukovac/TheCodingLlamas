using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheCodingLlamas.Models
{
    public class CodingLlamasDbContext: DbContext
    {
        public CodingLlamasDbContext(DbContextOptions<CodingLlamasDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
