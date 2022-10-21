using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Meta
    {
        public string Id { get; set; } = null!;
        public string? MetaAhorro { get; set; }
        public string? MetaSatisfaccion { get; set; }
        public string? AhoTotal { get; set; }
        public string? AhoAcu { get; set; }
        public string? SatisAcu { get; set; }
        public string? Ahotrimestre1 { get; set; }
        public string? Ahotrimestre2 { get; set; }
        public string? Ahotrimestre3 { get; set; }
        public string? Ahotrimestre4 { get; set; }
    }
}
