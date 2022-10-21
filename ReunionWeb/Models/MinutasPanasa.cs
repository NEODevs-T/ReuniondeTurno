using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class MinutasPanasa
    {
        public int MinutaId { get; set; }
        public string FecReunion { get; set; } = null!;
        public string FecProxReunion { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Solicitante { get; set; } = null!;
        public string Para { get; set; } = null!;
        public string Cc { get; set; } = null!;
    }
}
