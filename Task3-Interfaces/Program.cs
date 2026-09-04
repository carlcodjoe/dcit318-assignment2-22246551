// IMovable defines a contract: any class that implements it
// must provide its own Move() behavior. This lets different,
// unrelated classes (Car, Bicycle) share a common capability
// without needing to inherit from the same base class.
interface IMovable
{
    void Move();
}

// Car implements IMovable with its own specific behavior.
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle implements IMovable with its own specific behavior.
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create one instance of each class and call Move() on both.
        // Each produces different output despite sharing the same interface.
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();      // Car is moving
        bicycle.Move();  // Bicycle is moving
    }
}