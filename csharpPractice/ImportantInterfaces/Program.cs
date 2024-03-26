
using AdonetExample;
using ImportantInterfaces;

People people = new People();

foreach(var person in people)
{
    Console.WriteLine(person.FirstName);
}

Car car  = new Car();
car.Color = "Red";
car.Model = "X Corolla";

Car? car2 = car.Clone() as Car;

car2.Color = "Blue";

Console.WriteLine(car2.Color);
Console.WriteLine(car.Color);

using AdonetUtility adonetUtility = new AdonetUtility("");