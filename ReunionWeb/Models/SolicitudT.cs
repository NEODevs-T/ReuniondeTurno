using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class SolicitudT
    {
        public int IdSol { get; set; }
        public string? Nomproy { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecsol { get; set; }
        public string? Casa { get; set; }
        public string? Fecini { get; set; }
        public string? Fecfin { get; set; }
        public string? Nomsol { get; set; }
        public string? Area1 { get; set; }
        public string? Area2 { get; set; }
        public string? Obs { get; set; }
        public string? Validacion { get; set; }
        public string? Motivo { get; set; }
    }
}
