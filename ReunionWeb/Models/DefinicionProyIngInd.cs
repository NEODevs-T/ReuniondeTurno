using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class DefinicionProyIngInd
    {
        public string Cod { get; set; } = null!;
        public string? Problema { get; set; }
        public string? Raiz { get; set; }
        public string? Obj { get; set; }
        public string? Alcance { get; set; }
        public string? Actual { get; set; }
        public string? Propuestas { get; set; }
    }
}
