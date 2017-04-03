using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories
{
    public interface ITechnologyRepository
    {
        Task<List<Technology>> GetAllTechnologies();
        Technology GetTechnologyById(Guid id);
        void Insert(Technology model);
        void Update(Technology technology);
        void Delete(Guid id);
    }
}
