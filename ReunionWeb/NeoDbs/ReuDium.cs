using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.NeoDbs
{
    public partial class ReuDium
    {
        public ReuDium()
        {
            CambStats = new HashSet<CambStat>();
        }

        /// <summary>
        /// id tabla
        /// </summary>
        public int IdReuDia { get; set; }
        /// <summary>
        /// Id del pais
        /// </summary>
        public int IdPais { get; set; }
        [Required(ErrorMessage = "Campo Responsable Requerido.")]
        public int IdResReu { get; set; }
        /// <summary>
        /// Id del afectado
        /// </summary>
        [Required(ErrorMessage = "Campo KSF Requerido.")]
        public int Idksf { get; set; }
        /// <summary>
        /// centro o planta
        /// </summary>

        public string? Rdcentro { get; set; }
        /// <summary>
        /// Division
        /// </summary>

        public string? Rddiv { get; set; }
        /// <summary>
        /// Lineas o maquinas.
        /// </summary>
     
        public string? Rdarea { get; set; }
        /// <summary>
        /// Codigo del equipo
        /// </summary>
        [Required(ErrorMessage = "Campo C. Equipo Requerido.")]
        public string? RdcodEq { get; set; }
        /// <summary>
        /// Descripción de la discrepancia
        /// </summary>
        [Required(ErrorMessage = "Campo Discrepancia Requerido.")]
        public string? Rddisc { get; set; }
        /// <summary>
        /// Codigo del estado de la discrepancia.
        /// </summary>
       
        public string? RdcodDis { get; set; }
        /// <summary>
        /// Plan de acción.
        /// </summary>
        public string? RdplanAcc { get; set; }
        /// <summary>
        /// Tiempo de reparación de la discrepancia.
        /// </summary>
        public string? Rdtiempo { get; set; }
        /// <summary>
        /// Estado de las discrepancia
        /// </summary>
        [Required(ErrorMessage = "Campo Estado Requerido.")]
        public string? Rdstatus { get; set; }
        /// <summary>
        /// orden de trabajo
        /// </summary>
        public string? Rdodt { get; set; }
        /// <summary>
        /// Correlativo de la discrepancia si es mayor a un dia
        /// </summary>
        public string? RdnumDis { get; set; }
        /// <summary>
        /// fecha de la discrepancia planteada en la reunion
        /// </summary>
        public DateTime RdfecReu { get; set; }
        /// <summary>
        /// fecha planificada del trabajo.
        /// </summary>
        public DateTime RdfecTra { get; set; }
        /// <summary>
        /// observación.
        /// </summary>
        public string? Rdobs { get; set; }

        public virtual Pai IdPaisNavigation { get; set; } = null!;
        public virtual RespoReu IdResReuNavigation { get; set; } = null!;
        public virtual Ksf IdksfNavigation { get; set; } = null!;
        public virtual ICollection<CambStat> CambStats { get; set; }
        public virtual ICollection<CambFec> CambFec { get; set; }
    }
}