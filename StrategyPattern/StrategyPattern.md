# Strategy Pattern
## Think about this situation?
This is a duck pond simulation game. The game can show a large variety of duck species swimming and making quacking sounds. The initial designer of the system used standard OO techniques and created one Duck superclass from which all other duck types inherit.

![image](/StrategyPattern/P1.png)

*But now we need the ducks to fly!*
## Solution 1
![image](/StrategyPattern/P2.png)

But there is a problem that there were **rubber ducks** *flying* around the screen.
## Fix: Using Inhertance
![image](/StrategyPattern/P3.png)

![image](/StrategyPattern/P4.png)
![image](/StrategyPattern/P5.png)

Q: Which are disadvantages of using subclass to provide specific Duck behavior?

A: 
- Code is duplicated across subclasses.
- Runtime behavior changes are difficult.
- Hard to gain knowledge of all duck behaviors.
- Changes can unintentionally affect other ducks.

## Solution 2: Using interface
![image](/StrategyPattern/P6.png)

What do you think about this design?
## Solution 3: Using Strategy Pattern
**The Strategy pattern** defines a family of algorithms, Encapsulates each one, and makes them interchangeable. Strategy lets algorithm vary independently from clients that use it.
![image](/StrategyPattern/Duck.jpg)

**Advantages:** flexibility, maintainability, extensibility

**Disadvantages:** clients need to know all the strategy classes

**Cases:** different algorithms in different cirumstances