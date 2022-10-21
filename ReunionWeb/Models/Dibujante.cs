using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Dibujante
    {
        public int? OrdenTrab { get; set; }
        public int? IdEquipo { get; set; }
        public string? Descripcion { get; set; }
        public string? Supervisor { get; set; }
        public string? Responsable { get; set; }
        public int? Codigo { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public string? Solicitante { get; set; }
        public string? DescripcionLarga { get; set; }
        public string? IdPlano { get; set; }
        public float? Status { get; set; }
        public string? Payback { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaCompromiso { get; set; }
    }
}
