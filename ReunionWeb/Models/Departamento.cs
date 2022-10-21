using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Departamento
    {
        public int DepartId { get; set; }
        public string? Descripcion { get; set; }
        public int? Posicion { get; set; }
        /// <summary>
        /// DEPARTAMENTOS SELECCIONADOS 
        /// </summary>
        public int? DepSelec { get; set; }
        public int? Depmo { get; set; }
    }
}
