using System;
using lab10.Domain;

namespace lab10.Displays
{
    class StormWarningDisplay : WeatherDisplay
    {
        public override void Display()
        {
            if (currentWeather.WindSpeed <= 15) return;

            Console.WriteLine(
                "Внимание! Объявлено штормовое предупреждение! " +
                $"Ветер {currentWeather.WindDirection.GetNameOfDirection()}," +
                $"{currentWeather.WindSpeed} м/с");
        }
    }
}
