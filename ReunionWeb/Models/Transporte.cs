using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Transporte
    {
        public int Id { get; set; }
        public string? PlacaVeh { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Clase { get; set; }
        public string? Tipo { get; set; }
    }
}
