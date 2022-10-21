using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class PlanesPlantaSptte
    {
        public string Id { get; set; } = null!;
        public string? Fechaini { get; set; }
        public string? Fechafin { get; set; }
        public string? Sptte { get; set; }
        public string? Linea { get; set; }
        public string? Variable { get; set; }
        public string? Real { get; set; }
        public string? Objetivo { get; set; }
        public string? Discrepancia { get; set; }
        public string? Contencion { get; set; }
        public string? Correccion { get; set; }
        public string? Prevencion { get; set; }
        public int? Ttdte { get; set; }
    }
}
