using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class BrokeConv
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public string? Hora { get; set; }
        public string? Variable { get; set; }
        public string? Supervisor { get; set; }
        public string? Area { get; set; }
        public int? FechaBpcs { get; set; }
        public decimal? Valores { get; set; }
        public int? HoraVariable { get; set; }
        public int? Turno { get; set; }
        public string? Indicador { get; set; }
        public string? Observacion { get; set; }
        public string? Producto { get; set; }
        public string? Lote { get; set; }
        public string? Molino { get; set; }
        public string? Equipo { get; set; }
        public string? Grupo { get; set; }
    }
}
