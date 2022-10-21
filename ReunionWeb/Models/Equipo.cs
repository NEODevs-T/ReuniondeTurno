using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Equipo
    {
        public string IdEquipo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? IdMaq { get; set; }
        public int? Departaselec { get; set; }
    }
}
