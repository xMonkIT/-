using System;

namespace lab10.Domain
{
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

        public double Temperature { get; }

        public double Humidity { get; }

        public double Pressure { get; }

        public DateTime Time { get; }

        public WindDirection WindDirection { get; }

        public double WindSpeed { get; }
    }
}