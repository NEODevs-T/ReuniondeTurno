using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class NovMolino
    {
        public int Id { get; set; }
        public string Fecha { get; set; } = null!;
        public string Turno { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string Molino { get; set; } = null!;
        public string Division { get; set; } = null!;
        public string? Herra { get; set; }
        public string? Obsherra { get; set; }
        public string? Segui { get; set; }
        public string? Obssegui { get; set; }
        public string? Celda { get; set; }
    }
}
