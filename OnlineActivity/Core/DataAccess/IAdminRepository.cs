using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IAdminRepository<T,Y>
        where T : class, IEntity, new()
        where Y : class,IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<Y> GetAll(Expression<Func<Y, bool>> filter = null);
        Y Get(Expression<Func<Y, bool>> filter = null);
        void Add(Y entity);
        void Update(Y entity);
        void Delete(Y entity);

    }
}

