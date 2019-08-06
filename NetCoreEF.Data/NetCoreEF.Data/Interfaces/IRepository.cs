using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCore.Data
{
    public interface IRepository<T, C> where T : IEntity where C : DbContext
    {
        /// <summary>
        /// Contexto actual.
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// Obtiene el objeto mediante el Id en la base de datos.
        /// </summary>
        /// <param name="id">Id del objeto.</param>
        /// <returns></returns>
        T GetById(object id);

        /// <summary>
        /// Obtiene el objeto mediante el Id en la base de datos, para entidades con clave compuesta.
        /// </summary>
        /// <param name="id">array con claves.</param>
        /// <returns></returns>
        T GetById(object[] id);

        /// <summary>
        /// Inserta una entidad en la base de datos.
        /// </summary>
        /// <param name="entity">Entidad.</param>
        void Insert(T entity);

        /// <summary>
        /// Actualiza una entidad en la base de datos.
        /// </summary>
        /// <param name="entity">Entidad</param>
        void Update(T entity);

        /// <summary>
        /// Elimina una entidad de la base de datos.
        /// </summary>
        /// <param name="entity">Entidad.</param>
        void Delete(T entity);
      
        /// <summary>
        /// Obtiene todos los registros existentes de un objeto en la base de datos.
        /// </summary>
        IQueryable<T> GetAll { get; }

        /// <summary>
        /// Impacta todos los cambios realizados en la base de datos.
        /// </summary>
        void SaveChanges();
    }
}
