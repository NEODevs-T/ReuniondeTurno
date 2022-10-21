using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class MetasIp
    {
        public string Id { get; set; } = null!;
        public string? MetaSatisfaccion { get; set; }
        public string? SatisAcu { get; set; }
        public string? MetaRedu { get; set; }
        public string? ReduAcu { get; set; }
    }
}
