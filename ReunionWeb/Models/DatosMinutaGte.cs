using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class DatosMinutaGte
    {
        public string Id { get; set; } = null!;
        public string? Indicador { get; set; }
        public string? Um { get; set; }
        public string? Mes { get; set; }
        public string? Año { get; set; }
        public string? Dpto { get; set; }
        public string? Obs { get; set; }
        public string? Real { get; set; }
        public string? Obj { get; set; }
        public int? NroPosicion { get; set; }
        public int? Idpais { get; set; }
    }
}
