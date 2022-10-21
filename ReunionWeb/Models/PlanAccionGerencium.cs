using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class PlanAccionGerencium
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public string PlanAcc { get; set; } = null!;
        public string Avance { get; set; } = null!;
        public string Resp { get; set; } = null!;
        public string Fecfin { get; set; } = null!;
        public string? Finalizado { get; set; }
        public string Cod { get; set; } = null!;
    }
}
