using BlazorStrap;

namespace ReunionWeb.Pages
{
    public class Alerts
    {
        public bool _buttonDisabled = true;
        public BSAlert? _alertRef;
        public BSAlert? _alertRefErr;
        public BSAlert? _alertRefWar;
        public void Show()
        {
            _buttonDisabled = true;
            _alertRef?.Open();

        }

        public void ShowError()
        {
            _buttonDisabled = true;
            _alertRefErr?.Open();
        }
        public void ShowWarning()
        {
            _buttonDisabled = true;
            _alertRefWar?.Open();
        }
        public void Dismissed()
        {
            _buttonDisabled = false;
        }

    }
}
