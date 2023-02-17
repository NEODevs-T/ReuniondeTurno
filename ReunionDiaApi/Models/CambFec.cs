using System;
using System.Collections.Generic;

namespace ReunionDiaApi.Models
{
    public partial class CambFec
    {
        public int IdCambFec { get; set; }
        public string IdReuDia { get; set; } = null!;
        public DateTime Cffec { get; set; }
        public DateTime CffecNew { get; set; }
        public string Cfuser { get; set; } = null!;

        public virtual ReuDium IdCambFecNavigation { get; set; } = null!;
    }
}
