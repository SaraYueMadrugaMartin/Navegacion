namespace Pr02_SaraYueMadrugaMartin;

public partial class Galeria : ContentPage
{
	public Galeria()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        ImageButton imageButton = sender as ImageButton;

        if (imageButton == null) return;

        string horse = imageButton.CommandParameter.ToString();

        Datos data = new Datos();
        HorseData horseData = data.GetAnimalData(horse);

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