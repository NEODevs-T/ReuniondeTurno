using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class BonoProServicioBk
    {
        public DateTime? Fecha { get; set; }
        public string? Ficha { get; set; }
        public string? NombreTrab { get; set; }
        public string? PuestoTrab { get; set; }
        public int? TurnoTrab { get; set; }
        public decimal? MontoTotal { get; set; }
        public int? Validacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? PorsProceso { get; set; }
        public decimal? CampoA { get; set; }
        public string? CampoB { get; set; }
        public string? CampoC { get; set; }
        public string? FechaRegistro1 { get; set; }
    }
}
