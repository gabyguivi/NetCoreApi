using System;
using System.Collections.Generic;

namespace NetCore.Dominio
{
    public partial class Personas : Entity
    {
        public int Id { get; set; }
        public string NomyAp { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
    }
}
