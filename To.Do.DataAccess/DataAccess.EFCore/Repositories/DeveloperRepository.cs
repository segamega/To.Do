using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public DeveloperRepository(ApplicationContext context) : base(context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
