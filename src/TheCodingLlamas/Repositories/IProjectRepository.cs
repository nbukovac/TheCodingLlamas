using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCodingLlamas.Models;

namespace TheCodingLlamas.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllProjects();
        Project GetProjectById(Guid id);
        void Insert(Project project);
        void Update(Project project);
        void Delete(Guid projectId);
    }
}
