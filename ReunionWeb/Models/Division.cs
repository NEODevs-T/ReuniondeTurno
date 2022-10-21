using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Division
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public string? Division1 { get; set; }
        public string? Celda { get; set; }
        public string? Departamento { get; set; }
        public string? Zona { get; set; }
        public int? Centro { get; set; }
        public int? DivId { get; set; }
        public int? DpartId { get; set; }
    }
}
