using System;

namespace ForeignLanguageCenterPLC.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call SaveChanges from DbContext
        /// </summary>
        void Commit();
    }
}
