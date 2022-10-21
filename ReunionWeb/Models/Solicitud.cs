using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    /// <summary>
    /// Tabla que alberga los datos asociados a la solicitud de proyectos
    /// 
    /// </summary>
    public partial class Solicitud
    {
        /// <summary>
        /// Identificacion de la solicitud
        /// </summary>
        public int SolicitudId { get; set; }
        /// <summary>
        /// Nombre del proyecto solicitado
        /// </summary>
        public string? NomProy { get; set; }
        /// <summary>
        /// Fecha de solicitud del proyecto
        /// </summary>
        public string? FecSol { get; set; }
        /// <summary>
        /// Nombre del solicitante
        /// </summary>
        public string? NomSol { get; set; }
        public string? Tipoproy { get; set; }
        /// <summary>
        /// Numero del centro de costos de sub-area a donde se cargaran los gastos
        /// </summary>
        public string? CcsaSol { get; set; }
        public string? Prioridad { get; set; }
        public string? Validacion { get; set; }
        /// <summary>
        /// Nombre de la sub area donde se aplicará el proyecto
        /// </summary>
        public string? SubAa { get; set; }
        /// <summary>
        /// Área del solicitante
        /// </summary>
        public string? AreaSol { get; set; }
        public string? CcaSol { get; set; }
        public string? Causas { get; set; }
        public string? ProAlt { get; set; }
        public string? Motivo { get; set; }
        public string? Objetivo { get; set; }
        public string? Justificacion { get; set; }
        public string? Beneficios { get; set; }
        public string? Retorno { get; set; }
        public string? Tipo { get; set; }
        public string? Responsables { get; set; }
        public string? X { get; set; }
        public string? Y { get; set; }
        public string? Añosol { get; set; }
        public string? FacExito1 { get; set; }
    }
}
