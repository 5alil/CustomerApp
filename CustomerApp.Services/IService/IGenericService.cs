using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CustomerApp.Services.IService
{
    public interface IGenericService<T> : IService where T : class
    {
        T Get(int Id);
        T GetOneWithInclud(int Id, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetAllWithInclud(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity, object key);
        void Delete(T entity);
        void MarkAsDeleted(T entity, object key);
    }
}
