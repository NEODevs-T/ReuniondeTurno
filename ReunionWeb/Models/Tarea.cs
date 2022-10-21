using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Tarea
    {
        public int IdTarea { get; set; }
        public string Tarea1 { get; set; } = null!;
        public string Res { get; set; } = null!;
        public string Avance { get; set; } = null!;
        public string? Cli { get; set; }
        public string? Cliing { get; set; }
        public string? Ing { get; set; }
        public string FecEnt { get; set; } = null!;
        public string Idm { get; set; } = null!;
    }
}
