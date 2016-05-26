using System;
using System.Collections.Generic;
using System.Linq;
using lab10.Domain;

namespace lab10.Displays
{
    class StatisticsDisplay:WeatherDisplay
    {
        private IList<WeatherParams> AllParams = new List<WeatherParams>();

        public override void Display()
        {
            Console.WriteLine($"Средняя температура: {GetAvgTemperature()}, средняя влажность: { GetAvgHumidity()}, среднее давление: { GetAvgPressure()}");
        }

        private double GetAvgTemperature()
        {
            return AllParams.Average(x => x.Temperature);
        }

        private double GetAvgHumidity()
        {
            return AllParams.Average(x => x.Humidity);
        }

        private double GetAvgPressure()
        {
            return AllParams.Average(x => x.Pressure);
        }

        public override void Update(WeatherParams p)
        {
            AllParams.Add(p);
            base.Update(p);
        }

    }
}
