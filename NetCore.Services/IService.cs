using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Services
{
    public interface IService<T, C> where T : class where C : DbContext
    {
        T GetById(object id);
        T GetById(object[] id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }
}
