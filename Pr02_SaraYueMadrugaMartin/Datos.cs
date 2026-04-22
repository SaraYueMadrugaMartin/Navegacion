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
                    horseData.imagen = "img_mustang02.jpg";
                    horseData.familia = "Los caballos Mustang, también conocidos como el caballo cimarrón, son uno de los más destacados por su espíritu salvaje y carácter “indomable”. Además, son de los más llamativos por su belleza, su resistencia y su independencia.";
                    break;
                case "Appaloosa":
                    horseData.nombre = "Appaloosa";
                    horseData.imagen = "img_appaloosa02.jpg";
                    horseData.familia = "Esta es una característica única del caballo Appaloosa. Por lo tanto, la piel moteada es un indicador más importante. Ésta es diferente a la piel rosada común ya que tiene áreas oscuras intercaladas en la piel rosada y da como resultado una piel pecosa. Se localiza en diferentes partes del cuerpo. Además del hocico y alrededor de los ojos, también se localiza en el área genital.";
                    break;
                case "Paint":
                    horseData.nombre = "Paint";
                    horseData.imagen = "img_paint02.jpg";
                    horseData.familia = "El caballo Pinto tiene su origen en Norteamérica en el siglo XVI, cuando los primeros españoles llegaron a la zona, dirigidos por Hernán Cortés. Estos transportaron el caballo Barb Español, un cruce de otras razas presentes en el continente europeo (principalmente ruso y árabe). Estos nuevos caballos comenzaron a mezclarse con los caballos salvajes americanos, dando lugar al caballo Pinto que conocemos hoy en día, aunque su reconocimiento como raza no tuvo lugar hasta siglos más tarde.";
                    break;
                case "Friesian":
                    horseData.nombre = "Friesian";
                    horseData.imagen = "img_friesian02.jpg";
                    horseData.familia = "El caballo frisón posee unas características morfológicas muy particulares, su pelaje suele ser de color negro o castaño oscuro, con unas espesas crines alrededor de su cabeza y en su cola.Los caballos frisones son, por definición, caballos muy obedientes y fáciles de domar.";
                    break;
                case "Arabe":
                    horseData.nombre = "Arabe";
                    horseData.imagen = "img_arabe02.jpg";
                    horseData.familia = "El caballo árabe es una raza de caballos con raíces históricas en Asia occidental. Con una forma de cabeza distintiva y una cola alta, el árabe es una de las razas de caballos más fácilmente reconocibles del mundo. También es una de las razas modernas más antiguas.";
                    break;
                case "Haflinger":
                    horseData.nombre = "Haflinger";
                    horseData.imagen = "img_haflinger02.jpg";
                    horseData.familia = "La raza haflinger o avelignese es una raza de caballos desarrollada a finales del siglo XIX en el Tirol. Se trata de un caballo pequeño y robusto muy adaptado a marchar por la montaña.";
                    break;
                default:
                    break;
            }
            return horseData; // Se devuelve la informacion de la raza concreta.
        }
    }
}