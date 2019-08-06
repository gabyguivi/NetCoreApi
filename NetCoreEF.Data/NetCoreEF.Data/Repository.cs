using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCore.Data
{
    public class Repository<T, C> : IRepository<T, C> where T : Entity where C : DbContext
    {
        #region Propiedades

        public DbContext Context { get; }

        private DbSet<T> _entities;
        /// <summary>
        /// Colección de entidades.
        /// </summary>
        public DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = Context.Set<T>();
                }
                return _entities;
            }
        }

        #endregion

        #region Constructor

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        #endregion

        #region Métodos

        #region Públicos

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public T GetById(object[] id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            ((DbContext)Context).Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Remove(entity);
        }
        
        #region Virtuales

        public virtual IQueryable<T> GetAll
        {
            get
            {
                return this.Entities;
            }
        }

        public virtual void SaveChanges()
        {
            Context.SaveChanges();
        }

        #endregion

        #endregion

        #endregion
    }
}
