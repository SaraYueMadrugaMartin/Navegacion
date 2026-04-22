using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Pr02_SaraYueMadrugaMartin;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Metodo para comprobar la huella del usuario.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ClickedHuella(object sender, EventArgs e)
    {
        var request = new AuthenticationRequestConfiguration(title: "Autentication", reason: "Autenticar con huella");
        var result = await CrossFingerprint.Current.AuthenticateAsync(request);

        string userName = UserName.Text?.Trim();

        // Comprobar si el usuario se ha identificado correctamente para acceder a la siguiente pagina.
        if (result.Authenticated && !string.IsNullOrEmpty(userName)) // Debe estar relleno el campo de "Nombre" y poner la huella.
        {
            App.UserName = userName;

            Application.Current.MainPage = new AppShell(); // Se carga la nueva pagina.
        }
        else // Si no se identifica correctamente el usuario, sale el aviso de que algo falla.
            await DisplayAlert(title: "Acceso", message: "Acceso denegado", cancel: "Cerrar");
    }
}