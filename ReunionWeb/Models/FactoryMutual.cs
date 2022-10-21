using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class FactoryMutual
    {
        public string Codigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Fecha { get; set; }
        public string? Costo { get; set; }
        public string? Dpto { get; set; }
        public string? Resp { get; set; }
        public string? Tipo { get; set; }
        public string? Status { get; set; }
        public string? Riskmp { get; set; }
        public string? Riskmc { get; set; }
        public string? Coordinador { get; set; }
        public string? FechaRev { get; set; }
        public string? FechaCie { get; set; }
        public string? FechaApe { get; set; }
        public string? Avance { get; set; }
        public string? Observaciones { get; set; }
    }
}
