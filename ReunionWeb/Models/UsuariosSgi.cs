using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class UsuariosSgi
    {
        public string Ficha { get; set; } = null!;
        public string? Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Correo { get; set; }
        public string? Tlf { get; set; }
        public string? Ext { get; set; }
        public string? Cargo { get; set; }
        public string? Clave { get; set; }
        public string? Dpto { get; set; }
        public string? Area { get; set; }
        public string? Pais { get; set; }
        public int? Idpais { get; set; }
    }
}
