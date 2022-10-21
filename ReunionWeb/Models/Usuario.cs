using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Usuario
    {
        public string Ficha { get; set; } = null!;
        public string? Usuario1 { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Correo { get; set; }
        public string? Celular { get; set; }
        public string? Casa { get; set; }
        public string? Extension { get; set; }
        public string? Cargo { get; set; }
        public string? Estado { get; set; }
        public string? FecIng { get; set; }
        public string? FecVac { get; set; }
        public string? Sueldo { get; set; }
        public string? Clave { get; set; }
        public string? Nivel { get; set; }
        public string? NomSol { get; set; }
        public string? FecNac { get; set; }
        public string? AhoAcu { get; set; }
        public string? SatisAcu { get; set; }
        public string? MetaAho { get; set; }
        public string? MetaSatis { get; set; }
        public string? Hhsem { get; set; }
        public string? Cump { get; set; }
        public string? Dpto { get; set; }
        public string? Empresa { get; set; }
        public string? RutaFoto { get; set; }
        public string? NomFoto { get; set; }
        public string? FiltroConsultarProy { get; set; }
        public int? Idpais { get; set; }
    }
}
