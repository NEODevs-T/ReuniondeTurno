using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Idea
    {
        public int Id { get; set; }
        public string? NombreProyecto { get; set; }
        public string? Fecha { get; set; }
        public string? Resp1 { get; set; }
        public string? Resp2 { get; set; }
        public string? Resp3 { get; set; }
        public string? Resp4 { get; set; }
        public string? Resp5 { get; set; }
        public string? Area { get; set; }
        public string? Linea { get; set; }
        public string? Obj1 { get; set; }
        public string? Obj2 { get; set; }
        public string? Obj3 { get; set; }
        public string? Obj4 { get; set; }
        public string? Obj5 { get; set; }
        public string? Obj6 { get; set; }
        public string? Obj7 { get; set; }
        public string? Obj8 { get; set; }
        public string? Descripcion { get; set; }
        public string? Solucion { get; set; }
        public string? Factibilidad { get; set; }
        public int? Spa { get; set; }
        public string? Reconocimiento { get; set; }
        public int? NumProy { get; set; }
        public string? CoordinadorProy { get; set; }
        public string? Validacion { get; set; }
        public string? Criticidad { get; set; }
        public string? FechaBpcs { get; set; }
        public int? StideaId { get; set; }
        public int? Prioridad { get; set; }
    }
}
