using Domain.Entities.TaskManagement;

namespace Domain.Interfaces.TaskManagement
{
    /// <summary>
    /// Интерфейс для управления задачами.
    /// </summary>
    public interface ITaskRepository : IGenericRepository<Task>
    {
    }
}
