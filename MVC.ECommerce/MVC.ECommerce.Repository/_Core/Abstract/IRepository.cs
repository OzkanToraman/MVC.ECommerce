using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MVC.ECommerce.Repository._Core.Abstract
{
    public interface IRepository<T>
        where T : class , new()
    {
        void Add(T model);
        void Delete(int id);
        void Update(T model);
        List<T> GetList();
        IEnumerable<T> Where(Expression<Func<T, bool>> lambda);
        IQueryable<T> WhereByQuery(Expression<Func<T, bool>> lambda);
        T GetById(int id);
        bool GetAny(Expression<Func<T, bool>> lambda);
    }
}
