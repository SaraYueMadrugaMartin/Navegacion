using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Pr02_SaraYueMadrugaMartin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedHuella(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration(title: "Autentication", reason: "Autenticar con huella");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);

            if (result.Authenticated)
                await DisplayAlert(title: "Acceso", message: "Acceso concedido", cancel: "Cerrar");
            else
                await DisplayAlert(title: "Acceso", message: "Acceso denegado", cancel: "Cerrar");
        }
    }
}
