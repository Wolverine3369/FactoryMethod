using System;

namespace Wolverine
{
    interface ICar
    {
        void Car();
    }

    class Ford : ICar
    {
        public void Car()
        {
            Console.WriteLine("I am the Ford and I was produced by the Ford Factory!");
        }
    }

    class Dodge : ICar
    {
        public void Car()
        {
            Console.WriteLine("I am the Dodge and I was produced by the Dodge Factory!");
        }
    }

    interface IFactory
    {
        ICar ProduceCar();
    }

    class FordFactory : IFactory
    {
        public ICar ProduceCar()
        {
            return new Ford();
        }
    }

    class DodgeFactory : IFactory
    {
        public ICar ProduceCar()
        {
            return new Dodge();
        }
    }

    class Program
    {
        static void Main()
        {
            IFactory DodgeFactory = new DodgeFactory();
            ICar Dodge = DodgeFactory.ProduceCar();
            Dodge.Car();
        }
    }
}