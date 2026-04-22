namespace Pr02_SaraYueMadrugaMartin;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Metodo que cambia la fuente global de la aplicacion de manera dinamica.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeFontFamily(object sender, EventArgs e)
    {
        var font = ((Picker)sender).SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(font)) return;

        // Se aplica la fuente seleccionada a toda la pagina.
        Application.Current.Resources["AppFontFamily"] = font;

        // Guardar la fuente seleccionada.
        Preferences.Set("font", font);
    }
}