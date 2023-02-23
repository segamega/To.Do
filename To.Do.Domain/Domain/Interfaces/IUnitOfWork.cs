using System;

namespace Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        IDeveloperRepository Developers { get; }

        /// <summary>
        /// 
        /// </summary>
        IProjectRepository Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Complete();
    }
}
