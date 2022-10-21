using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Maquina
    {
        public int EqpId { get; set; }
        public string IdMaq { get; set; } = null!;
        public string? Zona { get; set; }
        public string? Dpto { get; set; }
        public int? DivId { get; set; }
    }
}
