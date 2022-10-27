using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Asistencium
    {
        public int Id { get; set; }
        public int? SptteProduccion { get; set; }
        public int? SupvProd { get; set; }
        public int? SupvMttoMecanico { get; set; }
        public int? SupvMttoElectricoElectronico { get; set; }
        public int? SupvInstrumentacion { get; set; }
        public int? Planificador { get; set; }
        public int? Calidad { get; set; }
        public int? Seguridad { get; set; }
        public int? MttoPrev { get; set; }
        public string? Area { get; set; }
        public int? Fecha { get; set; }
    }
}
