using System;
using System.Collections.Generic;
using System.Linq;
using lab10.Domain;

namespace lab10.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private readonly IList<WeatherParams> _allParams = new List<WeatherParams>();

        public override void Display()
        {
            Console.WriteLine($"Средняя температура: {GetAvgTemperature()}, средняя влажность: { GetAvgHumidity()}, среднее давление: { GetAvgPressure()}");
        }

        private double GetAvgTemperature() => _allParams.Average(x => x.Temperature);

        private double GetAvgHumidity() => _allParams.Average(x => x.Humidity);

        private double GetAvgPressure() => _allParams.Average(x => x.Pressure);

        public override void Update(WeatherParams p)
        {
            _allParams.Add(p);
            base.Update(p);
        }

    }
}
