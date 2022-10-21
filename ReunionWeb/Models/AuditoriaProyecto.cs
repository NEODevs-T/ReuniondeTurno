using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class AuditoriaProyecto
    {
        public int Id { get; set; }
        public string? Item { get; set; }
        public string? Cod { get; set; }
        public string? Aud { get; set; }
        public string? Dis { get; set; }
        public string? Planacc { get; set; }
        public string? Resp { get; set; }
        public string? Fecaud { get; set; }
        public string? Feccom { get; set; }
        public string? Finalizado { get; set; }
    }
}
