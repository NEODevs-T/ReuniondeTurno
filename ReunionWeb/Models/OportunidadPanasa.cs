using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class OportunidadPanasa
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public string? NomOpo { get; set; }
        public string? NomOpe { get; set; }
        public string? Linea { get; set; }
        public string? Puesto { get; set; }
        public string? Area { get; set; }
        public string? Descripcion { get; set; }
        public string? Propuesta { get; set; }
        public string? Analisis { get; set; }
        public string? NumSpa { get; set; }
        public string? NumProy { get; set; }
        public string? Reconocimiento { get; set; }
        public string? Supervisor { get; set; }
    }
}
