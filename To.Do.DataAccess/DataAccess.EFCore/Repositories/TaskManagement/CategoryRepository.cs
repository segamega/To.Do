using Domain.Entities.TaskManagement;
using Domain.Interfaces.TaskManagement;

namespace DataAccess.EFCore.Repositories.TaskManagement
{
    /// <summary>
    /// Репозиторий для объекта Категория.
    /// </summary>
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="context"></param>
        public CategoryRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
