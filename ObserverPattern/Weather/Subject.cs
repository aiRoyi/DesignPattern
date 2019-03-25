using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }

    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
    public interface DisplayElement
    {
        void Display();
    }
}
