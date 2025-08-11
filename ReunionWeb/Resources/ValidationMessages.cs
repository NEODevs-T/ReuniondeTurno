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





