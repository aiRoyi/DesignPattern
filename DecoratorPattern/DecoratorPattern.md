# Decorator Pattern
## Think about this situation?
Starbuzz Coffee is scrambling to update their ordering system to match their beverage offerings.
When they first went into business they designed their class like this.

![image](/DecoratorPattern/P1.PNG)

In addition to your coffee, you can also ask  for several condiments like steamed milk, soy, and mocha, and have it all topped off with whipped milk.Starbuzz charges a bit for each of these, so they really need to get them built into their order system.
Here's their first attempt.

![image](/DecoratorPattern/P2.PNG)

Thinking beyond the maintenance problem?
## The Open-Closed Principle
*Classes should be open for extension, but closed for modifition.*

**Our goal is to allow classes to be easily extended to incorporate new behavior without modifying existing code. What do we get if we accomplish this? Designs that are resilient to change and flexible enough to take on new functionality to meet changing requirements.**
## Decorator Pattern
**The Decorator Pattern** attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

So, here's what we'll do instead: we'll start with a beverage and "decorate" it with the condiments at runtime. For example, if the customer wants a Dark Roast with Mocha and Whip, then we'll:
- Take a DarkRoast object.
- Decorate it with a Mocha object.
- Decorate it with a Whip object.
- Call the cost() method and rely on delegation to add on the condiment costs.

![image](/DecoratorPattern/StarBuzzDesign.png)

**Advantages:** flexible, extensional.

**Disadvantages:** a large number of small classes.

**Cases:** new responsibilities need to be added to the object dynamically. 