using System.Globalization;

namespace UsuarioLib
{
    public class Coordenada
    {

        public Coordenada(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString()
        {
            return $"{Latitude.ToString(CultureInfo.InvariantCulture)}, {Longitude.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
