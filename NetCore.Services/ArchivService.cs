using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Dominio;
using System;

namespace NetCore.Services
{
    public class ArchivoService : BaseService<Persona, ArchivosContext>
    {
        public ArchivoService(IRepository<Persona, ArchivosContext> repository) : base(repository) { }

    }
}