using System.Collections.Generic;

namespace lab10.Domain
{
    public class Weatherdata : IWeatherObservable
    {

        private List<IWeatherObserver> observers = new List<IWeatherObserver>();

        /// <summary>
        /// Добавляет наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель</param>
        public void AddObserver(IWeatherObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// Оповещвет наблюдателей об изменениях в погоде
        /// </summary>
        /// <param name="p">Изменения в погоде</param>
        public void NotifyObservers(WeatherParams p)
        {
            observers.ForEach(o => o?.Update(p));
        }

        /// <summary>
        /// Удаляет наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель</param>
        public void RemoveObserver(IWeatherObserver o)
        {
            observers.Remove(o);
        }

        /// <summary>
        /// Вводит изменения в погоде
        /// </summary>
        /// <param name="p"></param>
        public void MeasurementsChanged(WeatherParams p)
        {
            NotifyObservers(p);
        }
    }
}
