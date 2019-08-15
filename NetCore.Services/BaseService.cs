using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using System;
using System.Collections.Generic;

namespace NetCore.Services
{
    public abstract class BaseService<T, C> : IService<T, C> where T : class where C : DbContext
    {
        #region Variables

        protected IRepository<T, C> _repository;

        #endregion

        #region Constructor

        protected BaseService(IRepository<T, C> repository)
        {
            _repository = repository;

        }
        #endregion

        #region Métodos

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll;
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public T GetById(object[] id)
        {
            return _repository.GetById(id);
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        #endregion
    }
}