using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Form2
    {
        public string IdSpa { get; set; } = null!;
        public string? Responsable { get; set; }
        public int? PersonalHn { get; set; }
        public int? PersonalHs { get; set; }
        public string? Ficha { get; set; }
        public string? C1 { get; set; }
        public string? C2 { get; set; }
        public string? Area { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Odt { get; set; }
        public string? UO { get; set; }
        public string? Discrepancia { get; set; }
        public string? Accion { get; set; }
        public string? Equipo { get; set; }
        public DateTime? FechaGrabado { get; set; }
        public string? Status { get; set; }
        public string? Observacion { get; set; }
        public int? IdSpa2 { get; set; }
        public string? Grupo { get; set; }
        public string? Turno { get; set; }
        public string? Odt1 { get; set; }
    }
}
