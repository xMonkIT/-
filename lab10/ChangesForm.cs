using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using lab10.Domain;

namespace lab10
{
    public partial class ChangesForm : Form
    {
        public Series Temperature = new Series("Температура") { ChartType = SeriesChartType.Line };
        public Series Pressure    = new Series("Давление")    { ChartType = SeriesChartType.Line };
        public Series Humidity    = new Series("Влажность")   { ChartType = SeriesChartType.Line };

        public ChangesForm()
        {
            InitializeComponent();

            cTemperature.Series.Clear();
            cPressure   .Series.Clear();
            cHumidity   .Series.Clear();

            cTemperature.Series.Add(Temperature);
            cPressure   .Series.Add(Pressure);
            cHumidity   .Series.Add(Humidity);
        }

        public void UpdateData(List<WeatherParams> weatherParamses)
        {
            if (IsDisposed) return;

            Action action = () =>
            {
                Temperature.Points.Clear();
                Pressure   .Points.Clear();
                Humidity   .Points.Clear();

                weatherParamses.ForEach(p =>
                {
                    Temperature.Points.Add(p.Temperature);
                    Pressure   .Points.Add(p.Pressure);
                    Humidity   .Points.Add(p.Humidity);
                });
            };

            if (InvokeRequired) Invoke(action);
            else action();
        }
    }
}
