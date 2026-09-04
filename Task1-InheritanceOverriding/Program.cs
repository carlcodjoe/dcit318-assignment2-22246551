// Base class representing a generic animal.
// MakeSound() is marked virtual so that subclasses can override it
// with their own specific behavior instead of using this default.
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Dog inherits from Animal and overrides MakeSound()
// to provide dog-specific behavior.
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Cat inherits from Animal and overrides MakeSound()
// to provide cat-specific behavior.
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create one instance of each class to demonstrate
        // that calling the same method name produces different
        // output depending on the actual object type at runtime.
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        genericAnimal.MakeSound(); // Some generic sound
        dog.MakeSound();           // Bark
        cat.MakeSound();           // Meow
    }
}