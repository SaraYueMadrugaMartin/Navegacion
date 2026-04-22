namespace Pr02_SaraYueMadrugaMartin;

public partial class Galeria : ContentPage
{
	public Galeria()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Metodo para identificar qué boton ha pulsado el usuario y abrir la pagina dinamica correspondiente con la informacion.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnCounterClicked(object sender, EventArgs e)
    {
        ImageButton imageButton = sender as ImageButton;

        if (imageButton == null) return;

        string horse = imageButton.CommandParameter.ToString(); // Se obtiene el ID del boton del caballo elegido.

        // Se obtienen los datos del caballo.
        Datos data = new Datos();
        HorseData horseData = data.GetAnimalData(horse);

        // Se navega a la pagina con la informacion corresponiente.
        Navigation.PushAsync(new PaginaSimple()
        {
            BindingContext = new HorseData
            {
                nombre = horseData.nombre,
                imagen = horseData.imagen,
                familia = horseData.familia,
            }
        });
    }
}