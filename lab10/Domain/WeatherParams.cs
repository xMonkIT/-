using System;

namespace lab10.Domain
{
    public enum WindDirection
    {
        N, NW, W, SW, S, SE, E, NE
    }

    public static class WindDirectionExtensions
    {
        public static string GetNameOfDirection(this WindDirection direction)
        {
            switch (direction)
            {
                case WindDirection.N:
                    return "северный";
                case WindDirection.NW:
                    return "северо-западный";
                case WindDirection.W:
                    return "западный";
                case WindDirection.SW:
                    return "юго-западный";
                case WindDirection.S:
                    return "южный";
                case WindDirection.SE:
                    return "юго-восточный";
                case WindDirection.E:
                    return "восточный";
                case WindDirection.NE:
                    return "северо-восточный";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public class WeatherParams
    {
        /// <summary>
        /// Создает экземпляр класса
        /// </summary>
        /// <param name="t">Температура в градусах</param>
        /// <param name="h">Влажность в %</param>
        /// <param name="p">Давление в мм рт. ст.</param>
        /// <param name="d">Направление ветра</param>
        /// <param name="s">Скорость ветра в м/с</param>
        public WeatherParams(double t, double h, double p, WindDirection d = WindDirection.S, double s = 7)
        {
            Temperature = t;
            Humidity = h;
            Pressure = p;
            Time = DateTime.Now;
            WindDirection = d;
            WindSpeed = s;
        }

        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        public DateTime Time { get; set; }

        public WindDirection WindDirection { get; set; }

        public double WindSpeed { get; set; }
    }
}