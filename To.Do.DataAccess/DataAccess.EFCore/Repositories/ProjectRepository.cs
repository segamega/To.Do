using Domain.Entities;
using Domain.Interfaces;

namespace DataAccess.EFCore.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
