using System;
using System.Collections.Generic;
using System.Threading;
using lab10.Displays;
using lab10.Domain;

namespace lab10
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var wd = new Weatherdata();

            var displays = new List<IWeatherObserver>
            {
                new CurrentStateDisplay(),
                new StatisticsDisplay(),
                new CurrentStateDisplay(),
                new ChangesDisplay(),
                new TodayMinMaxValuesDisplay(),
                new StormWarningDisplay(),
                new ForecastDisplay()
            };

            displays.ForEach(x=>x.Subscribe(wd));

            wd.MeasurementsChanged(new WeatherParams(15,60,760));
            Console.WriteLine();
            Thread.Sleep(1000);

            displays[2].UnSubscribe(wd);

            wd.MeasurementsChanged(new WeatherParams(18, 55, 745, s: 17));
            Console.WriteLine();
            Thread.Sleep(1000);

            wd.MeasurementsChanged(new WeatherParams(21, 50, 770));
            Console.WriteLine();
            Thread.Sleep(1000);

            var rand = new Random();

            for (int i = 0; i < rand.Next(10, 20); i++)
            {
                wd.MeasurementsChanged(new WeatherParams(
                    rand.Next(0, 30),
                    rand.Next(40, 90),
                    rand.Next(700, 800)));
                Console.WriteLine();
                Thread.Sleep(1000);
            }

            Console.Read();
        }
    }
}
