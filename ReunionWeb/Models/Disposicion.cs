using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Disposicion
    {
        public string? Dia { get; set; }
        public string? Mes { get; set; }
        public string? Año { get; set; }
        public string? PlacaVehiculo { get; set; }
        public decimal? PesoRomanaM { get; set; }
        public decimal? PesoRomanaP { get; set; }
        public decimal? CostoM { get; set; }
        public decimal? CostoP { get; set; }
    }
}
