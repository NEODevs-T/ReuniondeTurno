using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class AhorroCrp
    {
        /// <summary>
        /// Ahorro del proyecto Id
        /// </summary>
        public int AhoIdProye { get; set; }
        /// <summary>
        /// Crp Id
        /// </summary>
        public int AhoIdCrp { get; set; }
        /// <summary>
        /// Mes del  proyetos  de  Crp
        /// </summary>
        public string AhoMes { get; set; } = null!;
        /// <summary>
        /// Ahorro Real
        /// </summary>
        public decimal AhoReal { get; set; }
        /// <summary>
        /// Ahorro Budget
        /// </summary>
        public decimal AhoBudget { get; set; }
        /// <summary>
        /// Descripción de los departamentos   de Crp
        /// </summary>
        public string AhoDpto { get; set; } = null!;
    }
}
