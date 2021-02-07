using System;
using System.Collections;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void NotifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                ((IObserver)observers[i]).Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
