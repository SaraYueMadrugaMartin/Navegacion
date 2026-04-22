namespace Pr02_SaraYueMadrugaMartin
{
    public class HorseData
    {
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string familia { get; set; }
    }

    public class Datos
    {
        public HorseData animal = new HorseData();
        public HorseData GetAnimalData(string breedName)
        {
            switch (breedName)
            {
                case "Mustang":
                    animal.nombre = "Mustang";
                    animal.imagen = "img_mustang.jpg";
                    animal.familia = "Mustang";
                    break;
                case "Appaloosa":
                    animal.nombre = "Appaloosa";
                    animal.imagen = "img_appaloosa.jpg";
                    animal.familia = "Appaloosa";
                    break;
                case "Paint":
                    animal.nombre = "Paint";
                    animal.imagen = "img_paint.jpg";
                    animal.familia = "Paint";
                    break;
                case "Friesian":
                    animal.nombre = "Friesian";
                    animal.imagen = "img_friesian.jpg";
                    animal.familia = "Friesian";
                    break;
                default:
                    break;
            }
            return animal;
        }
    }
}