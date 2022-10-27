using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.Models
{
    public partial class BdDiv1
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Área Requerido.")]
        public string? Area { get; set; }
        [Required(ErrorMessage = "Campo Ksf Requerido.")]
        public string? Ksf { get; set; }
        [Required(ErrorMessage = "Campo Equipo Requerido.")]
        public string? CodigoEquipo { get; set; }
        [Required(ErrorMessage = "Campo Discrepancia Requerida.")]
        public string? Discrepancia { get; set; }
        public string? Codigo { get; set; }
        public string? PlanDeAccion { get; set; }
        public string? Tiempo { get; set; }
        public string? Responsable { get; set; }
        [Required(ErrorMessage = "Indique el status.")]
        public string? Status { get; set; }
        public string? Produfin { get; set; }
        public string? Ps { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaTrab { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]

        public string? Div { get; set; }
        public string? Fecha2 { get; set; }
        public string? FechaTrab1 { get; set; }
    }
}
