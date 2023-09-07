using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.DTOs
{
    public class EquipoDTO
    {
        public int IdEquipo { get; set; }
        [Required(ErrorMessage = "Campo  Requerido.")]
        public int IdLinea { get; set; }
        [Required(ErrorMessage = "Campo Código Requerido.")]
        public string EcodEquiEam { get; set; } = null!;
        [Required(ErrorMessage = "Campo Nombre Requerido.")]
        public string EnombreEam { get; set; } = null!;
        [Required(ErrorMessage = "Campo Descripción Requerida.")]
        public string EdescriEam { get; set; } = null!;
        public bool EestaEam { get; set; }
    }
}
