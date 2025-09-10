using System.Globalization;

public class UserCultureService
{
    public string CurrentCulture { get; private set; } = "es-ES";

    public void SetCultureFromUrl(string url)
    {
        if (url.Contains("/en/"))
            CurrentCulture = "en-US";
        else
            CurrentCulture = "es-ES";

        var cultureInfo = new CultureInfo(CurrentCulture);
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        Thread.CurrentThread.CurrentCulture = cultureInfo;
        Thread.CurrentThread.CurrentUICulture = cultureInfo;
    }
}
