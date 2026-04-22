namespace Pr02_SaraYueMadrugaMartin
{
    public partial class App : Application
    {
        public static string UserName { get; set; } = "Usuario"; // Variable estatica para el nombre del usuario.

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}