using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class TareaActividad
    {
        public int? IdTarea { get; set; }
        public string? Tarea { get; set; }
        public string? Actividad { get; set; }
        public decimal? Tiempo { get; set; }
    }
}
