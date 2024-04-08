using Event;

Car car = new Car();
car.carStarted += PrintOnCarStarted;

car.carStopped += PrintOnCarStopped;

car.Start();
car.Stop();

void PrintOnCarStarted(string ln)
{
    Console.WriteLine(ln);
}

void PrintOnCarStopped(string ln)
{
    Console.WriteLine(ln);
}
