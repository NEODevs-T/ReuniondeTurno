using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class RotaCaliV
    {
        public long IdGrupo { get; set; }
        public int IdPais { get; set; }
        public string? Fecha { get; set; }
        public int? Turno { get; set; }
        public string? Grupo { get; set; }
    }
}
