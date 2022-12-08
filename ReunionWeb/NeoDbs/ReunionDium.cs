using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.NeoDbs
{
    public partial class ReunionDium
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Área Requerido.")]
        public string? Area { get; set; }
        public string? Division { get; set; }
        [Required(ErrorMessage = "Indique el responsable.")]
        public string? Responsable { get; set; }
        [Required(ErrorMessage = "Campo Equipo Requerido.")]
        public string? CodigoEquipo { get; set; }
        [Required(ErrorMessage = "Campo Discrepancia Requerida.")]
        public string? Discrepancia { get; set; }
        public string? Codigo { get; set; }
        public string? PlanDeAccion { get; set; }
        public string? Tiempo { get; set; }
        [Required(ErrorMessage = "Campo Ksf Requerido.")]
        public string? AfectadoKsf { get; set; }
        [Required(ErrorMessage = "Indique el status.")]
        public string? Status { get; set; }
        public string? Produfin { get; set; }
        public string? OrdenTrabajo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaTrab { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]
        public string? Div { get; set; }
        public string? Fecha2 { get; set; }
        public string? FechaTrab1 { get; set; }
    }
}
