using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class Eficiencium
    {
        public int EficId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Fecha1 { get; set; }
        public decimal? EficA { get; set; }
        public decimal? EficB { get; set; }
        public decimal? EficC { get; set; }
        public decimal? EficD { get; set; }
        public decimal? EficTotal { get; set; }
        public int? Campo1 { get; set; }
        public int? Campo2 { get; set; }
        public int? CentroTrab { get; set; }
        /// <summary>
        /// Objetivo A
        /// </summary>
        public decimal? EfObjA { get; set; }
        /// <summary>
        /// Objetivo B
        /// </summary>
        public decimal? EfObjB { get; set; }
        /// <summary>
        /// Objetivo C
        /// </summary>
        public decimal? EfObjC { get; set; }
        /// <summary>
        /// Objetivo D
        /// </summary>
        public decimal? EfObjD { get; set; }
        /// <summary>
        /// Objetivo Total
        /// </summary>
        public decimal? EfObjTotal { get; set; }
        public string? EfUsuario { get; set; }
        public DateTime? EfechHora { get; set; }
    }
}
