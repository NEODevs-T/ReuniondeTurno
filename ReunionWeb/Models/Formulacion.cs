using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Formulacion
    {
        public int Id { get; set; }
        public string? IdSol { get; set; }
        public string? Item { get; set; }
        public string? Porcentaje { get; set; }
        public string? Texto { get; set; }
    }
}
