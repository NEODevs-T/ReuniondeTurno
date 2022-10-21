using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class SolicitudCambio
    {
        public int Id { get; set; }
        public string? Nomsol { get; set; }
        public string? FechaSol { get; set; }
        public string? FechaReq { get; set; }
        public string? FechaEje { get; set; }
        public string? VarEsp { get; set; }
        public string? Sitact { get; set; }
        public string? Sitpro { get; set; }
        public string? Justificacion { get; set; }
        public string? Area { get; set; }
        public string? Accion { get; set; }
        public string? Validacion { get; set; }
        public string? Analisis { get; set; }
        public string? Estado { get; set; }
    }
}
