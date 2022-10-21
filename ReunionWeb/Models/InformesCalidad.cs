using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class InformesCalidad
    {
        public string Id { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Cargado { get; set; }
        public string? Fecha { get; set; }
        public string? Ruta { get; set; }
        public string? Codigo { get; set; }
    }
}
