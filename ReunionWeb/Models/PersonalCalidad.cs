using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class PersonalCalidad
    {
        public string Ficha { get; set; } = null!;
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Ci { get; set; }
        public string? Cargo { get; set; }
        public string? Dpto { get; set; }
        public string? TlfMovil { get; set; }
        public string? TlfHab { get; set; }
        public string? Ext { get; set; }
        public string? Correo { get; set; }
        public string? FecIng { get; set; }
        public string? FecNac { get; set; }
        public string? RutaFoto { get; set; }
        public string? NomFoto { get; set; }
    }
}
