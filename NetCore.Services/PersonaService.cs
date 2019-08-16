using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Dominio;
using System;

namespace NetCore.Services
{
    public class PersonaService : BaseService<Persona, PrincipalContext>
    {
        public PersonaService(IRepository<Persona, PrincipalContext> repository) : base(repository) { }

    }
}