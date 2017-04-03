using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllPersons();
        Person GetById(Guid personId);
        void Insert(Person entity);
        void Update(Person entity);
        void Delete(Guid personId);
    }
}