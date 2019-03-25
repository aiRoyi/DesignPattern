using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 60, 30.4f);
            weatherData.SetMeasurements(50, 20, 20.4f);
            Console.ReadLine();
        }
    }
}
