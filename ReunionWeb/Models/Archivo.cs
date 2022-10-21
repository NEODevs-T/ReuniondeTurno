using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Archivo
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public string? Cod { get; set; }
        public string? Nombre { get; set; }
        public string? Fecsub { get; set; }
        public string? Archivo1 { get; set; }
    }
}
