using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Razor.Parser.SyntaxTree;

namespace NetCore.Data
{
    public interface IRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        /// <summary>
        /// Contexto actual.
        /// </summary>
        IContext<TContext> Context { get; }

        /// <summary>
        /// Obtiene el objeto mediante el Id en la base de datos.
        /// </summary>
        /// <param name="id">Id del objeto.</param>
        /// <returns></returns>
        TEntity GetById(object id);

        /// <summary>
        /// Obtiene el objeto mediante el Id en la base de datos, para entidades con clave compuesta.
        /// </summary>
        /// <param name="id">array con claves.</param>
        /// <returns></returns>
        TEntity GetById(object[] id);

        /// <summary>
        /// Inserta una entidad en la base de datos.
        /// </summary>
        /// <param name="entity">Entidad.</param>
        void Insert(TEntity entity);

        /// <summary>
        /// Actualiza una entidad en la base de datos.
        /// </summary>
        /// <param name="entity">Entidad</param>
        void Update(TEntity entity);

        /// <summary>
        /// Elimina una entidad de la base de datos.
        /// </summary>
        /// <param name="entity">Entidad.</param>
        void Delete(TEntity entity);
      
        /// <summary>
        /// Obtiene todos los registros existentes de un objeto en la base de datos.
        /// </summary>
        IQueryable<TEntity> GetAll { get; }

        /// <summary>
        /// Impacta todos los cambios realizados en la base de datos.
        /// </summary>
        void SaveChanges();
    }
}
