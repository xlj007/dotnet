using System;

namespace ObserverPattern
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
