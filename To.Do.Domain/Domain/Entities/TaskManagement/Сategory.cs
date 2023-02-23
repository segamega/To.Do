namespace Domain.Entities.TaskManagement
{
    /// <summary>
    /// Категория.
    /// </summary>
    public class Сategory
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Идентификатор родительской категории.
        /// </summary>
        public int? ParentId { get; set; }
    }
}
