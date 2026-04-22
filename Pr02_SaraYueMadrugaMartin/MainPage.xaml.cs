using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Pr02_SaraYueMadrugaMartin
{
    public partial class MainPage : ContentPage
    {
        public string WelcomeText => $"Bienvenido, {App.UserName}"; // Variable para mostrar en la pagina con el nombre del usuario.

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this; // Buscamos las propiedades de esta pagina para poder utilizarlas.
        }

        /// <summary>
        /// Método para navegar a la pagina de ajustes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}