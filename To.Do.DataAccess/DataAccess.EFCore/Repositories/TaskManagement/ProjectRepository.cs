using Domain.Entities.TaskManagement;
using Domain.Interfaces.TaskManagement;

namespace DataAccess.EFCore.Repositories.TaskManagement
{
    /// <summary>
    /// Репозиторий для объекта Проект.
    /// </summary>
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
