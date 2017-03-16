# Observer Pattern
## Think about this situation?
Your team has just won the contract to build Weather-O-Rama, Inc.'s next generation, Internet-based Weather Monitoring Station.

![image](/ObserverPattern/P1.PNG)

## The Weather Monitoring application overview
The three players in the system are the weather station(the physical device that acquires the actual weather data), the WeatherData object(that tracks the data comming from the Weather Station and updates the displays), and the display that shows users the current weather conditions.

![image](/ObserverPattern/P2.PNG)

**Our job is to create an app that uses the WeatherData object to update three displays for current conditions, weather stats, and a forecast.**

![image](/ObserverPattern/P3.PNG)

## Observer Pattern
**The Observer Pattern** defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

![image](/ObserverPattern/Obserber.png)

**When two objects are loosely coupled, they can interact, but have very liitle knowledge of each other. The Observer Pattern provides an object design where subjects and observers are loosly coupled.**
- The only thing the subject knows about an observer is that it implements a certain interface(the Observer interface). It doesn't need to know the concrete class of the observer, what it does, or anything else about it.
- We can add new observers at any time.
- We never need to modify the subject to add new types of observers.
- We can reuse subjects or observers independently of each other.
- Changes to either the subject or an observer will effect the other.

**Loosely coupled designs allow us to build flexible OO system that can handle change because they minimize the interdependency between objects.**

![image](/ObserverPattern/WeatherStation.png)


**Advantages:** loosely coupled.

**Disadvantages:** if a subject has a large number of observers, the efficiency problem will be occurred.

**Cases:** the state of an object updates, other objects need to synchronize update.
