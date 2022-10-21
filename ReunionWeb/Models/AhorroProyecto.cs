using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class AhorroProyecto
    {
        public int AhorroProyectoId { get; set; }
        public int? ProyectoId { get; set; }
        public int? Mes { get; set; }
        public decimal? Ahorro { get; set; }
    }
}
