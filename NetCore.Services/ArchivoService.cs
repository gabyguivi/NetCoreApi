using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Dominio;
using System;

namespace NetCore.Services
{
    public class ArchivoService : BaseService<Archivo, ArchivosContext>
    {
        public ArchivoService(IRepository<Archivo, ArchivosContext> repository) : base(repository) { }

    }
}