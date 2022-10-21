using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Form1
    {
        public string IdSpa { get; set; } = null!;
        public string? Responsable { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Turno { get; set; }
        public string? C1 { get; set; }
        public string? C2 { get; set; }
        public decimal? Nt { get; set; }
        public string? CampoA { get; set; }
        public string? CampoB { get; set; }
        public string? Descripcion { get; set; }
    }
}
