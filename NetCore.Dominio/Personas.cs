using NetCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Dominio
{
    [Table("Personas")]
    public partial class Persona
    {
        public int Id { get; set; }
        public string NomyAp { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
    }
}
