using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class CauCaliMol
    {
        /// <summary>
        /// ID CAUSAS DE CALIDAD DE  MOLINO
        /// </summary>
        public int CmidCauMol { get; set; }
        /// <summary>
        /// DESCRIPCIÓN  DE LAS CAUSA DE CALIDAD DE MOLINO
        /// </summary>
        public string Cmdescrip { get; set; } = null!;
        /// <summary>
        /// ESTATUS 1 ESTA ACTIVO SI ES 0 INACTIVO 
        /// </summary>
        public int Cmestatus { get; set; }
        /// <summary>
        /// CODIGO DE CAUSA
        /// </summary>
        public string CmcodCau { get; set; } = null!;
        /// <summary>
        /// ID DE LA TABLA NOVEDADES
        /// </summary>
        public int IdNovedade { get; set; }

        public virtual Novedade CmidCauMolNavigation { get; set; } = null!;
    }
}
