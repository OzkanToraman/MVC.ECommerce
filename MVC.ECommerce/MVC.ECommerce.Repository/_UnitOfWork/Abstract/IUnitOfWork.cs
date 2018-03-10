using System;
using MVC.ECommerce.Repository._Core.Abstract;

namespace MVC.ECommerce.Repository._UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Veritabanı güncelleştirmeleri kaydedilir.
        /// </summary>
        /// <param name="Commit"></param>
        int Commit();
        IRepository<T> GetRepo<T>() where T : class, new();
        void Dispose(bool disposing);
    }
}
