using NetCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Dominio
{
    [Table("Archivos")]
    public partial class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }        
    }
}
