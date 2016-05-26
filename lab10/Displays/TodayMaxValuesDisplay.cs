using System;
using System.Collections.Generic;
using System.Linq;
using lab10.Domain;

namespace lab10.Displays
{
    class TodayMaxValuesDisplay : WeatherDisplay
    {
        private readonly List<WeatherParams> _weatherParamsList = new List<WeatherParams>();

        

        public override void Display()
        {
            Console.WriteLine($"Максимальная температура: {GetMaxTodayTemperature()} градусов\n" +
                              $"Максимальное давление: {GetMaxTodayPressure()} мм\n" +
                              $"Максимальная влажность: {GetMaxTodayHumidity()}%\n");
        }

        private double GetMaxTodayTemperature() => _weatherParamsList
            .Where(x => x.Time.Date == DateTime.Today)
            .Select(x => x.Temperature)
            .Max();

        private double GetMaxTodayPressure() => _weatherParamsList
            .Where(x => x.Time.Date == DateTime.Today)
            .Select(x => x.Pressure)
            .Max();

        private double GetMaxTodayHumidity() => _weatherParamsList
            .Where(x => x.Time.Date == DateTime.Today)
            .Select(x => x.Humidity)
            .Max();

        public override void Update(WeatherParams p)
        {
            _weatherParamsList.Add(p);
            base.Update(p);
        }
    }
}
