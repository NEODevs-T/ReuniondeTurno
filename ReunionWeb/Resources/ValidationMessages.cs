using System.Resources;
using System.Globalization;

namespace ReunionWeb.Resources
{
    public static class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("ReunionWeb.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

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
    }
}
