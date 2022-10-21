using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class HitosPanasa
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public string? Cod { get; set; }
        public string? Nombre { get; set; }
        public string? Fecent { get; set; }
        public string? Planacc { get; set; }
        public string? Ent { get; set; }
        public string? Archivo { get; set; }
    }
}
