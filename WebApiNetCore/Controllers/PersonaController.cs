using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data;
using NetCore.Dominio;
using NetCore.Services;

namespace WebApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private PersonaService service;

        public PersonaController(PersonaService s) 
        {
            service = s;
        }
        // GET api/persona
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(service.GetAll());
        }

        // GET api/persona/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/persona
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/persona/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/persona/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
