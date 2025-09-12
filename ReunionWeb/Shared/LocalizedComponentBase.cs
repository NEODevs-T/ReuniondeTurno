using Microsoft.AspNetCore.Components;
using System.Globalization;
using ReunionWeb.Services;

namespace ReunionWeb.Shared
{
    public class LocalizedComponentBase : ComponentBase
    {
        [Inject] protected CultureService CultureService { get; set; }

        protected override void OnInitialized()
        {
            CultureInfo.CurrentCulture = CultureService.UserCulture;
            CultureInfo.CurrentUICulture = CultureService.UserCulture;
            base.OnInitialized();
        }
    }
}

