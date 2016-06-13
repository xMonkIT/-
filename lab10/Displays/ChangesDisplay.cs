using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using lab10.Domain;

namespace lab10.Displays
{
    class ChangesDisplay : WeatherDisplay
    {
        private readonly List<WeatherParams> _weatherParamsList = new List<WeatherParams>();

        public ChangesDisplay()
        {
            new Thread(() =>
            {
                var changesForm = new ChangesForm();
                UpdateValues += changesForm.UpdateData;
                Application.Run(changesForm);
            }).Start();
        }

        public event Action<List<WeatherParams>> UpdateValues; 
        
        public override void Display()
        {
            UpdateValues?.Invoke(_weatherParamsList);

            if (_weatherParamsList.Count < 2) return;
            var curr = _weatherParamsList[_weatherParamsList.Count - 1];
            var prev = _weatherParamsList[_weatherParamsList.Count - 2];

            Console.WriteLine(
                "Изменения по сравнению с предыдущим замером:\n" +
                $"\tВ температуре: {curr.Temperature - prev.Temperature} градусов\n" +
                $"\tВ давлении: {curr.Pressure - prev.Pressure} мм\n" +
                $"\tВо влажности: {curr.Humidity - prev.Humidity}%\n" +
                $"\tВремя между измерениями: {curr.Time - prev.Time}");
        }

        public override void Update(WeatherParams p)
        {
            _weatherParamsList.Add(p);
            base.Update(p);
        }
    }
}