using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class ConsolidadoRrhh
    {
        public string? Ficha { get; set; }
        public string? Nombre { get; set; }
        public string? Departamento { get; set; }
        public string? Puesto { get; set; }
        public int? AntigüedadCargo { get; set; }
        public string? Valor { get; set; }
        public string? Pregunta { get; set; }
        public decimal? PuntajeReal { get; set; }
        public int? PuntajeEsp { get; set; }
        public decimal? PuntajeSup { get; set; }
        public DateTime? Fecha { get; set; }
        public int? NumeroFecha { get; set; }
        public string? CampoA { get; set; }
        public string? CampoB { get; set; }
        public int? CampoC { get; set; }
        public decimal? Status { get; set; }
        public string? Compañia { get; set; }
        public string? FichaSup { get; set; }
        public string? TipoNom { get; set; }
    }
}
