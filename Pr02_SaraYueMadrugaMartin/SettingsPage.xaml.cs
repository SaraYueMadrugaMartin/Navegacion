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
        var optionFont = ((Picker)sender).SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(optionFont)) return;

        // Se aplica la fuente seleccionada a toda la pagina.
        Application.Current.Resources["AppFontFamily"] = optionFont;

        // Guardar la fuente seleccionada.
        Preferences.Set("font", optionFont);
    }

    /// <summary>
    /// Metodo que cambia el tamaño global de la fuente de la acplicacion de manera dinamica.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeFontSize(object sender, EventArgs e)
    {
        var optionSize = ((Picker)sender).SelectedItem?.ToString();

        // Se asigna un numero como multiplicador para cada opción de tamaño elegido.
        double scale = optionSize switch
        {
            "Pequeño" => 0.5,
            "Normal" => 1.0,
            "Grande" => 2,
            _ => 1.0
        };

        // Se recalculan los tamaños de la fuentes globales con la escala corresponiente esocgida.
        Application.Current.Resources["FontTitle"] = 32 * scale;
        Application.Current.Resources["FontSubtitle"] = 22 * scale;
        Application.Current.Resources["FontBody"] = 16 * scale;

        // Se guarda el tamaño escogido.
        Preferences.Set("scale", scale);
    }

    /// <summary>
    /// Metodo que cambia el color global de la fuente de la aplicación de manera dinaminca.
    /// Tiene en cuenta el modo dia - noche del dispositivo.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeFontColor(object sender, EventArgs e)
    {
        var optionColor = ((Picker)sender).SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(optionColor)) return;

        // Se asignan dos colores, uno para cada modo, de manera que se puedan ver bien.
        (Color light, Color dark) = optionColor switch
        {
            "Rojo" => (Color.FromArgb("#911313"), Color.FromArgb("#FF6161")),
            "Azul" => (Color.FromArgb("#173DB3"), Color.FromArgb("#8CD8F5")),
            "Amarillo" => (Color.FromArgb("#DDE330"), Color.FromArgb("#EEF2BD")),
            _ => (Color.FromArgb("#000000"), Color.FromArgb("#FFFFFF"))
        };

        // Se aplican los colores correspondientes a la aplicacion.
        Application.Current.Resources["ColorLightMode"] = light;
        Application.Current.Resources["ColorDarkMode"] = dark;

        // Se guarda el color escogido.
        Preferences.Set("color", optionColor);
    }
}