using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Auditoria
    {
        public string Id { get; set; } = null!;
        public string? NomAud { get; set; }
        public string? Dpto { get; set; }
        public string? Zona { get; set; }
        public string? Ubic { get; set; }
        public string? FecAud { get; set; }
        public string? Quincena { get; set; }
        public string? Tipo { get; set; }
        public int? OrgFisAct { get; set; }
        public int? ConPro { get; set; }
        public int? GesProd { get; set; }
        public int? AlmIns { get; set; }
        public int? AlmHerr { get; set; }
        public int? Seguridad { get; set; }
        public int? Reunion { get; set; }
        public int? Asent { get; set; }
        public int? OrgFisNue { get; set; }
        public int? Comunicacion { get; set; }
        public int? TiempoPerd { get; set; }
        public int? AlmSat { get; set; }
        public int? Rutinas { get; set; }
        public int? Total { get; set; }
        public string? Supervisor { get; set; }
        public string? Grupo { get; set; }
        public string? Mes { get; set; }
        public string? Año { get; set; }
        public int? NMes { get; set; }
        public string? Cc { get; set; }
    }
}
