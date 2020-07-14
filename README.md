# CF - 401 - Lab 06 - OOP Principles (1/2)
​
## Lab 06 - OOP Principles (1/2)
​
*Author: Paul M Rest*
*Author: Bade J Habib*
​
----
​
## Description
​
Console app that instantiates five concrete animal classes, Shark, Dog, Wolf, Rhino, and Hippo, using three layers of inheritance and four abstract classes.
​
Demonstrates that each of the five concrete animal classes inherit from their abstract base class(es).
​
---
​
## Technical Overview
​
Employs the OOP principles of inheritance and abstraction to build off base class properties and methods (states and behavior) towards concrete classes that can be instantiated.
​
Inheritance - we have a base abstract class, Animal, that has various properties and methods. The three abstract child classes of Animal, Fish, Canine, and Pachyderm, override some of these properties and methods. Then the five, concrete, classes, Shark, Dog, Wolf, Hippo, and Rhino, implement all of them.
​
Abstraction - our five concrete classes use various properties and methods defined in the abstract classes. For example, both Dog and Wolf know how to Sniff(), Swim(), and MarkTerritory() as they gain those methods from their abstract parent class, Canine.
​
---
​
### Getting Started
Clone this repository to your local machine.
​
In a command line environment with Git installed:
​
```
git clone <<GIT REPO URL HERE>>
```
​
### To Run the Program from Visual Studio (2019):
Select ```File``` -> ```Open``` -> ```Project/Solution```
​
Next navigate to the directory you cloned the repository to.
​
Double click on the ```Lab06-OOP-Principles``` directory.
​
Then select and open ```Lab06-OOP-Principles.sln```
​
Select ```Debug``` -> ```Start Debugging``` to the run the app with the debugger
​
OR
​
Select ```Debug``` -> ```Start Without Debugging```
​
---
​
### Visuals
​
#### Console App
​
![](./Lab06-OOP-Principles/assets/lab06-oop-principles.png)
​
#### UDM
​
![](./Lab06-OOP-Principles/assets/ZooUML.png)
​
---
​
### Current Version
​
v1.0
​
### Change Log
​
#### 2020-07-13