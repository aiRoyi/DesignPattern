using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float Temperature;
        private float Humidity;
        private Subject WeatherData;
        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions:" + Temperature + "F degrees and" + Humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.Temperature = temp;
            this.Humidity = humidity;
            Display();
        }
    }
}
