using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCore.Data
{
    public class Repository<TEntity, TContext> : IRepository<TEntity, TContext>
    where TEntity : class where TContext : DbContext
    {
        #region Propiedades

        public IContext<TContext> Context { get; }

        private DbSet<TEntity> _entities;
        /// <summary>
        /// Colección de entidades.
        /// </summary>
        public DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = Context.Set<TEntity>();
                }
                return _entities;
            }
        }

        #endregion

        #region Constructor

        public Repository(IContext<TContext> context)
        {
            this.Context = context;
        }

        #endregion

        #region Métodos

        #region Públicos

        public TEntity GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public TEntity GetById(object[] id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            ((DbContext)Context).Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Remove(entity);
        }
        
        #region Virtuales

        public virtual IQueryable<TEntity> GetAll
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
