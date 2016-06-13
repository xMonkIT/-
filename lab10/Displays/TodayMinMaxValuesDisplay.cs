using System;
using System.Collections.Generic;
using System.Linq;
using lab10.Domain;

namespace lab10.Displays
{
    internal class TodayMinMaxValuesDisplay : WeatherDisplay
    {
        private readonly List<WeatherParams> _weatherParamsList = new List<WeatherParams>();

        public override void Display() =>
            Console.WriteLine(
                "Амплитуды показателей за сегодня:\n" +
                $"\tТемпература: {GetTodayRange(x => x.Temperature, "градусов")}\n" +
                $"\tДавление:    {GetTodayRange(x => x.Pressure, "мм")}\n" +
                $"\tВлажность:   {GetTodayRange(x => x.Humidity, "%")}");

        private IEnumerable<double> GetToday(Func<WeatherParams, double> selector) =>
            _weatherParamsList
                .Where(x => x.Time.Date == DateTime.Today)
                .Select(selector);

        private string GetTodayRange(Func<WeatherParams, double> selector, string dimension) =>
            $"{GetToday(selector).Min(),3} - {GetToday(selector).Max(),3} {dimension}";

        public override void Update(WeatherParams p)
        {
            _weatherParamsList.Add(p);
            base.Update(p);
        }
    }
}
