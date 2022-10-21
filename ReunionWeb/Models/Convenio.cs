using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Convenio
    {
        public string? Ficha { get; set; }
        public string? NombreTrab { get; set; }
        public string? PuestoTrab { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Area { get; set; }
        public string? Dpto { get; set; }
        public int? Conv1 { get; set; }
        public int? Conv2 { get; set; }
        public string? FechaHoraRegistro { get; set; }
    }
}
