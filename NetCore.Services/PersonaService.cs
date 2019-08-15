using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Dominio;
using System;

namespace NetCore.Services
{
    public class PersonaService : BaseService<Persona, ProyectoFinalContext>
    {
        public PersonaService(IRepository<Persona, ProyectoFinalContext> repository) : base(repository) { }

    }
}