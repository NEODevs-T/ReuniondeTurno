using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class PlanesGte
    {
        public string Id { get; set; } = null!;
        public string? Problema { get; set; }
        public string? Descripcion1 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Descripcion3 { get; set; }
        public string? Resp1 { get; set; }
        public string? Resp2 { get; set; }
        public string? Resp3 { get; set; }
        public string? Result1 { get; set; }
        public string? Result2 { get; set; }
        public string? Result3 { get; set; }
        public string? Fecha1 { get; set; }
        public string? Fecha2 { get; set; }
        public string? Fecha3 { get; set; }
        public string? Problema2 { get; set; }
        public int? Idpais { get; set; }
    }
}
