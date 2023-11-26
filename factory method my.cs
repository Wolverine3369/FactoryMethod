using System;

namespace Wolverine
{
    interface ICar
    {
        void Model2022();
        void Model2023();
    }

    class Ford : ICar
    {
        public void Model2022()
        {
            Console.WriteLine("I am a Ford model 2022 and I was produced by the Ford Factory!");
        }

        public void Model2023()
        {
            Console.WriteLine("I am a Ford model 2023 and I was produced by the Ford Factory!");
        }
    }

    class Dodge : ICar
    {
        public void Model2022()
        {
            Console.WriteLine("I am a Dodge model 2022 and I was produced by the Dodge Factory!");
        }

        public void Model2023()
        {
            Console.WriteLine("I am a Dodge model 2023 and I was produced by the Dodge Factory!");
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
            IFactory FordFactory = new FordFactory();
            ICar Dodge = DodgeFactory.ProduceCar();
            ICar Ford = FordFactory.ProduceCar();
            Dodge.Model2022();
            Ford.Model2023();
        }
    }
}