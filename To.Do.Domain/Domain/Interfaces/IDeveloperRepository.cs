using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}