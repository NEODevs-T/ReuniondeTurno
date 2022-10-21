using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class RotacionMcbo
    {
        public int Fecha { get; set; }
        public string? Turno1 { get; set; }
        public string? Turno2 { get; set; }
        public string? Libre { get; set; }
    }
}
