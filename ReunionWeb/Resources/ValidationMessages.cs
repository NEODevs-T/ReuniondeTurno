using System.Resources;
using System.Globalization;

namespace ReunionWeb.Resources
{
    public static class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("ReunionWeb.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

        public static ResourceManager ResourceManager => _resourceManager;

        public static string RequiredUserName => _resourceManager.GetString("RequiredUserName", CultureInfo.CurrentUICulture);
        public static string RequiredPassword => _resourceManager.GetString("RequiredPassword", CultureInfo.CurrentUICulture);
        public static string Consolidacion => _resourceManager.GetString("Consolidacion", CultureInfo.CurrentUICulture);
        public static string Linea => _resourceManager.GetString("Linea", CultureInfo.CurrentUICulture);
        public static string C_Equipo => _resourceManager.GetString("C_Equipo", CultureInfo.CurrentUICulture);
        public static string Discrepancia => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentUICulture);
        public static string PlanDeAccion => _resourceManager.GetString("PlanDeAccion", CultureInfo.CurrentUICulture);
        public static string F_Reunion => _resourceManager.GetString("F_Reunion", CultureInfo.CurrentUICulture);
        public static string Acciones => _resourceManager.GetString("Acciones", CultureInfo.CurrentUICulture);
        public static string Centro => _resourceManager.GetString("Centro", CultureInfo.CurrentUICulture);
        public static string Division => _resourceManager.GetString("Division", CultureInfo.CurrentUICulture);
        public static string Buscar => _resourceManager.GetString("Buscar", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaDivision => _resourceManager.GetString("SeleccioneUnaDivision", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnCentro => _resourceManager.GetString("SeleccioneUnCentro", CultureInfo.CurrentUICulture);
        public static string hay_registros_vencidos => _resourceManager.GetString("hay_registros_vencidos", CultureInfo.CurrentUICulture);
        public static string ConsolidacionDeDiscrepancia => _resourceManager.GetString("ConsolidacionDeDiscrepancia", CultureInfo.CurrentUICulture);
        public static string OrgDelProducto => _resourceManager.GetString("OrgDelProducto", CultureInfo.CurrentUICulture);
        public static string DetallesDeCalidad => _resourceManager.GetString("DetallesDeCalidad", CultureInfo.CurrentUICulture);
        public static string Responsable => _resourceManager.GetString("Responsable", CultureInfo.CurrentUICulture);
        public static string PlanDeAcción => _resourceManager.GetString("PlanDeAcción", CultureInfo.CurrentUICulture);
        public static string NombreDelEquipo => _resourceManager.GetString("NombreDelEquipo", CultureInfo.CurrentUICulture);
        public static string CodigoDeEquipo => _resourceManager.GetString("CodigoDeEquipo", CultureInfo.CurrentUICulture);
        public static string Area => _resourceManager.GetString("Area", CultureInfo.CurrentUICulture);
        public static string Imprimir => _resourceManager.GetString("Imprimir", CultureInfo.CurrentUICulture);
        public static string Aceptar => _resourceManager.GetString("Aceptar", CultureInfo.CurrentUICulture);
        public static string EnCurso => _resourceManager.GetString("EnCurso", CultureInfo.CurrentUICulture);
        public static string Codigo => _resourceManager.GetString("Codigo", CultureInfo.CurrentUICulture);
        public static string Seleccione => _resourceManager.GetString("Seleccione", CultureInfo.CurrentUICulture);
        public static string FormatoDeReunion => _resourceManager.GetString("FormatoDeReunion", CultureInfo.CurrentUICulture);
        public static string Estado => _resourceManager.GetString("Estado", CultureInfo.CurrentUICulture);
        public static string Consultar => _resourceManager.GetString("Consultar", CultureInfo.CurrentUICulture);
        public static string FiltroFechaDeReunion => _resourceManager.GetString("FiltroFechaDeReunion", CultureInfo.CurrentUICulture);
        public static string Cerrado => _resourceManager.GetString("Cerrado", CultureInfo.CurrentUICulture);
        public static string Pendiente => _resourceManager.GetString("Pendiente", CultureInfo.CurrentUICulture);
        public static string Todo => _resourceManager.GetString("Todo", CultureInfo.CurrentUICulture);
        public static string Desde => _resourceManager.GetString("Desde", CultureInfo.CurrentUICulture);
        public static string Hasta => _resourceManager.GetString("Hasta", CultureInfo.CurrentUICulture);
        public static string Historicos => _resourceManager.GetString("Historicos", CultureInfo.CurrentUICulture);
        public static string Accion => _resourceManager.GetString("Accion", CultureInfo.CurrentUICulture);
        public static string FechaDeReunion => _resourceManager.GetString("FechaDeReunion", CultureInfo.CurrentUICulture);
        public static string Discrepancias => _resourceManager.GetString("Discrepancias", CultureInfo.CurrentUICulture);
        public static string Filtrar => _resourceManager.GetString("Filtrar", CultureInfo.CurrentUICulture);
        public static string Guardar => _resourceManager.GetString("Guardar", CultureInfo.CurrentUICulture);
        public static string Borrar => _resourceManager.GetString("Borrar", CultureInfo.CurrentUICulture);
        public static string Asuntos => _resourceManager.GetString("Asuntos", CultureInfo.CurrentUICulture);
        public static string Todos => _resourceManager.GetString("Todos", CultureInfo.CurrentUICulture);
        public static string Ordenar => _resourceManager.GetString("Ordenar", CultureInfo.CurrentUICulture);
        public static string FReunion => _resourceManager.GetString("FReunion", CultureInfo.CurrentUICulture);
        public static string DetallesCalidad => _resourceManager.GetString("DetallesCalidad", CultureInfo.CurrentUICulture);
        public static string Trazabilidad => _resourceManager.GetString("Trazabilidad", CultureInfo.CurrentUICulture);
        public static string CambiosDeEstados => _resourceManager.GetString("CambiosDeEstados", CultureInfo.CurrentUICulture);
        public static string FechaDelCambio => _resourceManager.GetString("FechaDelCambio", CultureInfo.CurrentUICulture);
        public static string StatusNuevo => _resourceManager.GetString("StatusNuevo", CultureInfo.CurrentUICulture);
        public static string Usuario => _resourceManager.GetString("Usuario", CultureInfo.CurrentUICulture);
        public static string EditarDiscrepancia => _resourceManager.GetString("EditarDiscrepancia", CultureInfo.CurrentUICulture);
        public static string ObservacionesDeCalidad => _resourceManager.GetString("ObservacionesDeCalidad", CultureInfo.CurrentUICulture);
        public static string Atras => _resourceManager.GetString("Atras", CultureInfo.CurrentUICulture);
        public static string Listo => _resourceManager.GetString("Listo", CultureInfo.CurrentUICulture);
        public static string NuevaFechaDeTrabajo => _resourceManager.GetString("NuevaFechaDeTrabajo", CultureInfo.CurrentUICulture);
        public static string Correcto => _resourceManager.GetString("Correcto", CultureInfo.CurrentUICulture);
        public static string NEquipo => _resourceManager.GetString("NEquipo", CultureInfo.CurrentUICulture);
        public static string Reunion => _resourceManager.GetString("Reunion", CultureInfo.CurrentUICulture);
        public static string NoHayRegistros => _resourceManager.GetString("NoHayRegistros", CultureInfo.CurrentUICulture);
        public static string NoHayEquipos => _resourceManager.GetString("NoHayEquipos", CultureInfo.CurrentUICulture);
        public static string NoHayDatos => _resourceManager.GetString("NoHayDatos", CultureInfo.CurrentUICulture);
        public static string NoHayRegistros2 => _resourceManager.GetString("NoHayRegistros2", CultureInfo.CurrentUICulture);
        public static string NoHayDatos2 => _resourceManager.GetString("NoHayDatos2", CultureInfo.CurrentUICulture);
        public static string NoHayDescrip => _resourceManager.GetString("NoHayDescrip", CultureInfo.CurrentUICulture);
        public static string Exito => _resourceManager.GetString("Exito", CultureInfo.CurrentUICulture);
        public static string Error => _resourceManager.GetString("Error", CultureInfo.CurrentUICulture);
        public static string Advertencia => _resourceManager.GetString("Advertencia", CultureInfo.CurrentUICulture);
        public static string Atencion => _resourceManager.GetString("Atencion", CultureInfo.CurrentUICulture);
        public static string RExitoso => _resourceManager.GetString("RExitoso", CultureInfo.CurrentUICulture);
        public static string EDato => _resourceManager.GetString("EDato", CultureInfo.CurrentUICulture);
        public static string TCargos => _resourceManager.GetString("TCargos", CultureInfo.CurrentUICulture);
        public static string RHorario => _resourceManager.GetString("RHorario", CultureInfo.CurrentUICulture);
        public static string SSuplente => _resourceManager.GetString("SSuplente", CultureInfo.CurrentUICulture);
        public static string Asistencia => _resourceManager.GetString("Asistencia", CultureInfo.CurrentUICulture);
        public static string Asistentes => _resourceManager.GetString("Asistentes", CultureInfo.CurrentUICulture);
        public static string Bloque => _resourceManager.GetString("Bloque", CultureInfo.CurrentUICulture);
        public static string Personal => _resourceManager.GetString("Personal", CultureInfo.CurrentUICulture);
        public static string Presencia => _resourceManager.GetString("Presencia", CultureInfo.CurrentUICulture);
        public static string Suplencia => _resourceManager.GetString("Suplencia", CultureInfo.CurrentUICulture);
        public static string NoCargadoP => _resourceManager.GetString("NoCargadoP", CultureInfo.CurrentUICulture);
        public static string ErrorInser => _resourceManager.GetString("ErrorInser", CultureInfo.CurrentUICulture);
        public static string SArea => _resourceManager.GetString("SArea", CultureInfo.CurrentUICulture);
        public static string SDivision => _resourceManager.GetString("SDivision", CultureInfo.CurrentUICulture);
        public static string LlDisp => _resourceManager.GetString("LlDisp", CultureInfo.CurrentUICulture);
        public static string SEstado => _resourceManager.GetString("SEstado", CultureInfo.CurrentUICulture);
        public static string NSDatos => _resourceManager.GetString("NSDatos", CultureInfo.CurrentUICulture);
        public static string SCentro => _resourceManager.GetString("SCentro", CultureInfo.CurrentUICulture);
        public static string ErrorInesp => _resourceManager.GetString("ErrorInesp", CultureInfo.CurrentUICulture);
        public static string NFDatos => _resourceManager.GetString("NFDatos", CultureInfo.CurrentUICulture);
        public static string SVLista => _resourceManager.GetString("SVLista", CultureInfo.CurrentUICulture);
        public static string ODT => _resourceManager.GetString("ODT", CultureInfo.CurrentUICulture);
        public static string Reload => _resourceManager.GetString("Reload", CultureInfo.CurrentUICulture);
        public static string SVCentro => _resourceManager.GetString("SVCentro", CultureInfo.CurrentUICulture);
        public static string SVDivision => _resourceManager.GetString("SVDivision", CultureInfo.CurrentUICulture);
        public static string NPA1 => _resourceManager.GetString("NPA1", CultureInfo.CurrentUICulture);
        public static string NPA2 => _resourceManager.GetString("NPA2", CultureInfo.CurrentUICulture);
        public static string MapResponsableKey(string nombre)
        {
            return nombre switch
            {
                "Mtto. Mecánico" => "Mtto_Mecanico",
                "Mtto. Eléctrico/Electrónico" => "Mtto_ElectricoElectronico",
                "Seguridad" => "Seguridad",
                "Calidad" => "Calidad",
                "Operaciones" => "Operaciones",
                "Por Definir" => "Por_Definir",
                _ => nombre
            };
        }

    }   

}





