using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class TallerAutomotrizMc
    {
        public string? Equipo { get; set; }
        public string? Ficha { get; set; }
        public string? PersonalResp { get; set; }
        public string? Grupo { get; set; }
        public int? FechaEnt { get; set; }
        public string? HoraEnt { get; set; }
        public int? FechaSal { get; set; }
        public string? HoraSal { get; set; }
        public string? TiempoRep { get; set; }
        public string? TrabRealizado { get; set; }
        public string? MotivoRep { get; set; }
        public string? TipoServ { get; set; }
        public string? TipoMant { get; set; }
        public int Id { get; set; }
        public string? Observaciones { get; set; }
        public int? Horometro { get; set; }
    }
}
