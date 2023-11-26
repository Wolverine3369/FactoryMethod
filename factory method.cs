using System;

// Product interface
interface IProduct
{
    void Display();
}

// Concrete product A
class ConcreteProductA : IProduct
{
    public void Display()
    {
        Console.WriteLine("Concrete Product A");
    }
}

// Concrete product B
class ConcreteProductB : IProduct
{
    public void Display()
    {
        Console.WriteLine("Concrete Product B");
    }
}

// Creator interface
interface ICreator
{
    IProduct FactoryMethod();
}

// Concrete creator A
class ConcreteCreatorA : ICreator
{
    public IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

// Concrete creator B
class ConcreteCreatorB : ICreator
{
    public IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

class Program
{
    static void ClientCode(ICreator creator)
    {
        // Using the factory method to create a product
        IProduct product = creator.FactoryMethod();
        product.Display();
    }

    //static void Main()
    //{
        // Client uses creator A
    //    ICreator creatorA = new ConcreteCreatorA();
    //    ClientCode(creatorA);

        // Client uses creator B
    //    ICreator creatorB = new ConcreteCreatorB();
    //    ClientCode(creatorB);
    //}
}
