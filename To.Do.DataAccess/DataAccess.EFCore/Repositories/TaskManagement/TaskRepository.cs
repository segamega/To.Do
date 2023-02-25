using Domain.Interfaces.TaskManagement;
using Task = Domain.Entities.TaskManagement.Task;

namespace DataAccess.EFCore.Repositories.TaskManagement
{
    /// <summary>
    /// Репозиторий для объекта Задача.
    /// </summary>
    public class TaskRepository : GenericRepository<Task>, ITaskRepository
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="context"></param>
        public TaskRepository(ApplicationContext context) : base(context)
        {
        }
    }
}