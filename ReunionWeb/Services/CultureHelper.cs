using System;
using System.Globalization;
using System.Threading.Tasks;

public static class CultureHelper
{
    public static async Task RunWithCultureAsync(Func<Task> func, string culture)
    {
        if (string.IsNullOrEmpty(culture)) culture = "es-ES";
        var ci = new CultureInfo(culture);

        var oldCulture = CultureInfo.CurrentCulture;
        var oldUi = CultureInfo.CurrentUICulture;
        try
        {
            CultureInfo.CurrentCulture = ci;
            CultureInfo.CurrentUICulture = ci;
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            await func().ConfigureAwait(false);
        }
        finally
        {
            CultureInfo.CurrentCulture = oldCulture;
            CultureInfo.CurrentUICulture = oldUi;
            CultureInfo.DefaultThreadCurrentCulture = oldCulture;
            CultureInfo.DefaultThreadCurrentUICulture = oldUi;
        }
    }
}
