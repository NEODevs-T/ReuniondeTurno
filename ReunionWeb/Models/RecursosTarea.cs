using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class RecursosTarea
    {
        public string? Tarea { get; set; }
        public string? TipoRecurso { get; set; }
        public string? Recurso { get; set; }
        public int? Cantidad { get; set; }
        public int? IdTarea { get; set; }
    }
}
