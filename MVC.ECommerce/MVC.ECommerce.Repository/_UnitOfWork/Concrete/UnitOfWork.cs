using System;
using System.Data.Entity;
using MVC.ECommerce.Repository._Core.Abstract;
using MVC.ECommerce.Repository._Core.Concrete;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;

namespace MVC.ECommerce.Repository._UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DbContext _dbContext;
        protected bool _disposed = false; 

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public int Commit()
        {
            int resultSet = 0;

            using (_dbContext.Database.BeginTransaction())
            {
                try
                {
                    resultSet = _dbContext.SaveChanges();
                    _dbContext.Database.CurrentTransaction.Commit();
                }
                catch (Exception)
                {
                    _dbContext.Database.CurrentTransaction.Rollback();
                    resultSet = 0;
                    throw;
                }
            }
            return resultSet;
        }

        public void Dispose(bool disposing)
        {
            if (_disposed ==false)
            {
                Dispose();
                _disposed = true;
                _dbContext = null;
            }


        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepo<T>() where T : class, new()
        {
            return new EFRepositoryBase<T>(_dbContext);
        }
    }
}
