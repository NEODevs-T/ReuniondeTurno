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
    }
}
