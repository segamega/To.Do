using Domain.Entities.TaskManagement;

namespace Domain.Interfaces.TaskManagement
{
    /// <summary>
    /// Интерфейс для управлением категориями.
    /// </summary>
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}
