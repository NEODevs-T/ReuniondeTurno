using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Fifo
    {
        public DateTime? Fecha { get; set; }
        public string? Producto { get; set; }
        public decimal? Consumido { get; set; }
        public decimal? EnDiscrepancia { get; set; }
        public decimal? EficienciaFifo { get; set; }
        public string? CampoA { get; set; }
        public string? CampoB { get; set; }
        public string? CampoC { get; set; }
        public string? Area { get; set; }
        public string? Fecha1 { get; set; }
        public decimal? CantLotes { get; set; }
        public decimal? CumplimientoFifo { get; set; }
        public decimal? Directas { get; set; }
        public decimal? Discrepancias { get; set; }
        public decimal? Efectividad { get; set; }
        public string? FechaA { get; set; }
        public int? Fecha2 { get; set; }
    }
}
