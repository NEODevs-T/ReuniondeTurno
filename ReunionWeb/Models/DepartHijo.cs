using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class DepartHijo
    {
        public int DepartamentoHijoId { get; set; }
        public int? DepartamentoId { get; set; }
        public string? Descripcion { get; set; }
        public int? DivId { get; set; }
    }
}
