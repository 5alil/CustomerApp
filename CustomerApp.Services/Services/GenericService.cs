using CustomerApp.Repository.IRepository;
using CustomerApp.Repository.UnitOfWork;
using CustomerApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace CustomerApp.Services.Services
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public GenericService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public T Get(int Id)
        {
            return _repository.Get(Id);
        }

        public T GetOneWithInclud(int Id, params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.GetOneIncluding(Id,includeProperties);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> GetAllWithInclud(params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.GetAllIncluding(includeProperties);
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();
        }


        public virtual void Update(T entity, object key)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Update(entity,key);
            _unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual void MarkAsDeleted(T entity, object key)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty("IsDeleted");
            propertyInfo.SetValue(entity, Convert.ChangeType(true, propertyInfo.PropertyType), null);
            Update(entity, key);
        }
    }
}
