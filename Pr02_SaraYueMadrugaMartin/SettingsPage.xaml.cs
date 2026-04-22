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

    /// <summary>
    /// Metodo que cambia el tamaño global de la fuente de la acplicacion de manera dinamica.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeFontSize(object sender, EventArgs e)
    {
        var option = ((Picker)sender).SelectedItem?.ToString();

        // Se asigna un numero como multiplicador para cada opción de tamaño elegido.
        double scale = option switch
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
}