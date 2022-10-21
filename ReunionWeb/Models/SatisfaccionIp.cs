using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class SatisfaccionIp
    {
        public int Id { get; set; }
        public string Cod { get; set; } = null!;
        public string T1 { get; set; } = null!;
        public string T2 { get; set; } = null!;
        public string C1 { get; set; } = null!;
        public string C2 { get; set; } = null!;
        public string I1 { get; set; } = null!;
        public string A1 { get; set; } = null!;
        public string A2 { get; set; } = null!;
        public string G1 { get; set; } = null!;
        public string? Obs { get; set; }
        public string Nivel { get; set; } = null!;
    }
}
