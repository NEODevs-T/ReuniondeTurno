using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class DatosGte
    {
        public string Id { get; set; } = null!;
        public string? Valor { get; set; }
        public string? Variable { get; set; }
        public string? Mes { get; set; }
        public string? Año { get; set; }
        public string? Dpto { get; set; }
        public int? Idpais { get; set; }
    }
}
