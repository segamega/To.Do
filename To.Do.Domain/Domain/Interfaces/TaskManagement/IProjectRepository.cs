using Domain.Entities.TaskManagement;

namespace Domain.Interfaces.TaskManagement
{
    /// <summary>
    /// Интерфейс для управления проектами.
    /// </summary>
    public interface IProjectRepository : IGenericRepository<Project>
    {
    }
}
