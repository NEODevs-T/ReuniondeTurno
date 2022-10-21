using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Crp
    {
        public int Id { get; set; }
        public DateTime? FechaActual { get; set; }
        public string? Proyecto { get; set; }
        public string? CalProyecto { get; set; }
        public string? Dpto { get; set; }
        public string? FechaImplementacion { get; set; }
        public string? FechaCulminacion { get; set; }
        public decimal? Porc { get; set; }
        public decimal? MontoIndividual { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? Enero { get; set; }
        public decimal? Febrero { get; set; }
        public decimal? Marzo { get; set; }
        public decimal? Abril { get; set; }
        public decimal? Mayo { get; set; }
        public decimal? Junio { get; set; }
        public decimal? Julio { get; set; }
        public decimal? Agosto { get; set; }
        public decimal? Septiembre { get; set; }
        public decimal? Octubre { get; set; }
        public decimal? Noviembre { get; set; }
        public decimal? Diciembre { get; set; }
        public string? Mes { get; set; }
        public int? Año { get; set; }
        public string? Status { get; set; }
        public string? DescRechazo { get; set; }
        public string? MesR { get; set; }
        public decimal? Real { get; set; }
        public decimal? Idpro { get; set; }
        public int? Ididea { get; set; }
    }
}
