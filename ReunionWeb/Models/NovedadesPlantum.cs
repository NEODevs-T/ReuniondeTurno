using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class NovedadesPlantum
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public string? Grupo { get; set; }
        public string? Turno { get; set; }
        public string? Supervisor { get; set; }
        public string? IdMaquina { get; set; }
        public string? NomMaquina { get; set; }
        public string? IdEquipo { get; set; }
        public string? NomEquipo { get; set; }
        public string? Novedad { get; set; }
        public string? Status { get; set; }
        public string? Div { get; set; }
        public string? Concatena { get; set; }
        public string? Dpto { get; set; }
        public string? Accion { get; set; }
        public decimal? Nt { get; set; }
        public string? CampoA { get; set; }
        public string? CampoB { get; set; }
        public string? FechaProgramada { get; set; }
        public decimal? Odt { get; set; }
        public string? IdSpa { get; set; }
        public decimal? Avtotal { get; set; }
        public decimal? Avparcial { get; set; }
        public string? GrupoAvance { get; set; }
        /// <summary>
        /// Calificacion
        /// </summary>
        public decimal? NovCalific { get; set; }
    }
}
