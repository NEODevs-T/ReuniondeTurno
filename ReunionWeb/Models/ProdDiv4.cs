using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class ProdDiv4
    {
        public string Id { get; set; } = null!;
        public string? Fecha { get; set; }
        public string? Grupo { get; set; }
        public string? Turno { get; set; }
        public string? Supervisor { get; set; }
        public string? Maquina { get; set; }
        public string? Produccion { get; set; }
    }
}
