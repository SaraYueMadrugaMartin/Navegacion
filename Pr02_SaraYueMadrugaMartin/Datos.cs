namespace Pr02_SaraYueMadrugaMartin
{
    /// <summary>
    /// Clase que contiene los datos de los parametros para la informacion de cada raza de caballo.
    /// </summary>
    public class HorseData
    {
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string familia { get; set; }
    }

    /// <summary>
    /// Clase que gestiona la informacion de cada raza, para mostrar en la pagina dinamica.
    /// </summary>
    public class Datos
    {
        public HorseData horseData = new HorseData();

        /// <summary>
        /// Metodo que recibe el nombre de la raza concreta.
        /// Gestiona la informacion de la raza seleccionada.
        /// </summary>
        /// <param name="breedName"></param>
        /// <returns> Devuelve la informacion de la raza de caballo seleccionada por el usuario. </returns>
        public HorseData GetAnimalData(string breedName)
        {
            switch (breedName)
            {
                case "Mustang":
                    horseData.nombre = "Mustang";
                    horseData.imagen = "img_mustang.jpg";
                    horseData.familia = "Mustang";
                    break;
                case "Appaloosa":
                    horseData.nombre = "Appaloosa";
                    horseData.imagen = "img_appaloosa.jpg";
                    horseData.familia = "Appaloosa";
                    break;
                case "Paint":
                    horseData.nombre = "Paint";
                    horseData.imagen = "img_paint.jpg";
                    horseData.familia = "Paint";
                    break;
                case "Friesian":
                    horseData.nombre = "Friesian";
                    horseData.imagen = "img_friesian.jpg";
                    horseData.familia = "Friesian";
                    break;
                default:
                    break;
            }
            return horseData; // Se devuelve la informacion de la raza concreta.
        }
    }
}