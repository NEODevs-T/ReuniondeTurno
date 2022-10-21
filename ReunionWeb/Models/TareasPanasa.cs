using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class TareasPanasa
    {
        public int IdTarea { get; set; }
        public string Tarea { get; set; } = null!;
        public string Res { get; set; } = null!;
        public string Avance { get; set; } = null!;
        public string? Cli { get; set; }
        public string? Cliing { get; set; }
        public string? Ing { get; set; }
        public string FecEnt { get; set; } = null!;
        public string Idm { get; set; } = null!;
    }
}
