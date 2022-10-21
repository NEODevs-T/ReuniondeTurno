using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class IndGte
    {
        public string Id { get; set; } = null!;
        public string? Indicador { get; set; }
        public string? Um { get; set; }
        public string? Tipo { get; set; }
        public int? Posicion { get; set; }
        public string? Dpto { get; set; }
        public string? Act { get; set; }
        public int? Idpais { get; set; }
    }
}
