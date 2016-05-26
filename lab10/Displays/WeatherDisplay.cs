using lab10.Domain;

namespace lab10.Displays
{
    abstract class WeatherDisplay:IDisplay,IWeatherObserver
    {
        protected WeatherParams currentWeather;

        /// <summary>
        /// Отображает данные
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Подписывается на наблюдаемый объект
        /// </summary>
        /// <param name="ob">Объект наблюдения</param>
        public void Subscribe(IWeatherObservable ob)
        {
            ob.AddObserver(this);
        }

        /// <summary>
        /// Отписывается от наблюдения за объектом
        /// </summary>
        /// <param name="ob">Объект наблюдения</param>
        public void UnSubscribe(IWeatherObservable ob)
        {
            ob.RemoveObserver(this);
        }

        /// <summary>
        /// Обновляет данные наблюдателя
        /// </summary>
        /// <param name="p">Новые данные о погоде</param>
        public virtual void Update(WeatherParams p)
        {
            currentWeather = p;
            Display();
        }

    }
}
