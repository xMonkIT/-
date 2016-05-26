namespace lab10.Domain
{
    public interface IWeatherObservable
    {
        /// <summary>
        /// Добавляет наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель</param>
        void AddObserver(IWeatherObserver o);

        /// <summary>
        /// Удаляет наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель</param>
        void RemoveObserver(IWeatherObserver o);

        /// <summary>
        /// Оповещвет наблюдателей об изменениях в погоде
        /// </summary>
        /// <param name="p">Изменения в погоде</param>
        void NotifyObservers(WeatherParams p);
    }
}
