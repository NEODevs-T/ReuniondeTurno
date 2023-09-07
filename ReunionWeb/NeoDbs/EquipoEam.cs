using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.NeoDbs
{
    public partial class EquipoEam
    {
        public int IdEquipo { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido.")]    
        public int IdLinea { get; set; }
        [Required(ErrorMessage = "Campo Requerido.")]
        public string EcodEquiEam { get; set; } = null!;
        [Required(ErrorMessage = "Campo Requerido.")]
        public string EnombreEam { get; set; } = null!;
        [Required(ErrorMessage = "Campo Requerido.")]
        public string EdescriEam { get; set; } = null!;
        [Required(ErrorMessage = "Campo Requerido.")]
        public bool EestaEam { get; set; }
        public virtual Linea IdLineaNavigation { get; set; } = null!;
    }
}
