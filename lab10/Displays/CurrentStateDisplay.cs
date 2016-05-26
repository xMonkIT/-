using System;

namespace lab10.Displays
{
    class CurrentStateDisplay : WeatherDisplay
    {
        public override void Display()
        {
            Console.WriteLine($"Температура сейчас {currentWeather.Temperature} градусов, влажность {currentWeather.Humidity}%, а давление: {currentWeather.Pressure} мм.");
        }
    }
}
