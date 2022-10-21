using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class AvanceSemanalPanasa
    {
        public int? Id { get; set; }
        public string? Codigo { get; set; }
        public string? Semana { get; set; }
        public string? ProgEsp { get; set; }
        public string? ProgReal { get; set; }
        public string? PorAvance { get; set; }
    }
}
