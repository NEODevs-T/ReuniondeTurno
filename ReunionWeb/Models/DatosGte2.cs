using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class DatosGte2
    {
        public string Id { get; set; } = null!;
        public string? Año { get; set; }
        public string? Mes { get; set; }
        public string? Real { get; set; }
        public string? Objetivo { get; set; }
        public string? Variable { get; set; }
        public string? Dpto { get; set; }
        public int? MesNro { get; set; }
        public int? Idpais { get; set; }
    }
}
