using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class TareasEquipo
    {
        public int IdTarea { get; set; }
        public string? Pais { get; set; }
        public string? Compañia { get; set; }
        public string? Dpto { get; set; }
        public string? Division { get; set; }
        public string? Linea { get; set; }
        public string? IdEquipo { get; set; }
        public string? Tarea { get; set; }
        public decimal? Tiemp { get; set; }
    }
}
