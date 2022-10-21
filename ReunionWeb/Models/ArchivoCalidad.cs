using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class ArchivoCalidad
    {
        public string Codigo { get; set; } = null!;
        public string? NomArchivo { get; set; }
        public string? FecAct { get; set; }
        public string? ModPor { get; set; }
        public string? Ruta { get; set; }
        public string? TipoArchivo { get; set; }
    }
}
