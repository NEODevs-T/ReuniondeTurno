using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Novedade
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
        public string? IdTipoCausa { get; set; }
        public string? IdCausa { get; set; }
        public string? DescTipocausa { get; set; }
        public string? Criticidad { get; set; }
        public string? Ksf { get; set; }
        public int? Acertividad { get; set; }
        public string? PersonaEvaluar { get; set; }
        public string? CausaRaiz { get; set; }
        public string? PlanAccionRaiz { get; set; }
        public int? FechaAcertividad { get; set; }
        public string? FechaAcertividad1 { get; set; }
        /// <summary>
        /// Codigo del Articulo
        /// </summary>
        public string? NvcodArt { get; set; }
        public string? IdCausa2 { get; set; }
        public string? IdCausa3 { get; set; }
        public DateTime? Nvhora { get; set; }

        public virtual CauCaliMol? CauCaliMol { get; set; }
    }
}
