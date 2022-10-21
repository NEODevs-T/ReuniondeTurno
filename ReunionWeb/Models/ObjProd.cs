using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class ObjProd
    {
        public int Id { get; set; }
        public string? Celda { get; set; }
        public string? Producto { get; set; }
        public string? Cajas { get; set; }
        public string? CajasEfic { get; set; }
    }
}
