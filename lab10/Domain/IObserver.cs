namespace lab10.Domain
{
    public interface IWeatherObserver
    {
        /// <summary>
        /// Обновляет данные наблюдателя
        /// </summary>
        /// <param name="p">Новые данные</param>
        void Update(WeatherParams p);

        /// <summary>
        /// Подписаться на наблюдаемый объект
        /// </summary>
        /// <param name="ob">Объект наблюдения</param>
        void Subscribe(IWeatherObservable ob);

        /// <summary>
        /// Отписаться от наблюдения за объектом
        /// </summary>
        /// <param name="ob">Объект наблюдения</param>
        void UnSubscribe(IWeatherObservable ob);
    }
}
