using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherData : Subject
    {
        private List<Observer> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure;
        public WeatherData()
        {
            Observers = new List<Observer>();
        }
        public void NotifyObservers()
        {
            for (int i= 0;i<Observers.Count;i++)
            {
                Observer observer = Observers[i];
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            Observers.Remove(o);
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
