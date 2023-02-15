using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class EquipoEam
    {
        public int IdEquipo { get; set; }
        public int IdLinea { get; set; }
        public string EcodEquiEam { get; set; } = null!;
        public string EnombreEam { get; set; } = null!;

        public virtual Linea IdLineaNavigation { get; set; } = null!;
    }
}
