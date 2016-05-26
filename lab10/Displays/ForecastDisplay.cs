using System;
using System.Collections.Generic;
using System.Linq;
using lab10.Domain;

namespace lab10.Displays
{
    class ForecastDisplay : WeatherDisplay
    {
        private readonly IList<WeatherParams> _weatherParamsList = new List<WeatherParams>();
        private const int Accuracy = 3;

        public override void Display()
        {
            if (_weatherParamsList.Count < Accuracy) return;

            bool? isRaising = null;

            if (currentWeather.Pressure > 765 &&
                _weatherParamsList.SequenceEqual(_weatherParamsList.OrderBy(x => x.Temperature)))
                isRaising = true;
            else if (currentWeather.Pressure < 750 &&
                     _weatherParamsList.SequenceEqual(_weatherParamsList.OrderByDescending(x => x.Temperature)))
                isRaising = false;

            Console.WriteLine(isRaising.HasValue
                ? $"Температура будет {(isRaising.Value ? "увеличиваться" : "уменьшаться")}"
                : "Прогноз погоды неопределен");
        }

        public override void Update(WeatherParams p)
        {
            _weatherParamsList.Add(p);
            if (_weatherParamsList.Count > Accuracy) _weatherParamsList.RemoveAt(0);

            base.Update(p);
        }
    }
}
