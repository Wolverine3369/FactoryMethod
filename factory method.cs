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
            Console.WriteLine("I am the Ford model 2022 and I was produced by the Ford Factory!");
        }

        public void Model2023()
        {
            Console.WriteLine("I am the Ford model 2023 and I was produced by the Ford Factory!");
        }
    }

    class Dodge : ICar
    {
        public void Model2022()
        {
            Console.WriteLine("I am the Dodge model 2022 and I was produced by the Dodge Factory!");
        }

        public void Model2023()
        {
            Console.WriteLine("I am the Dodge model 2023 and I was produced by the Dodge Factory!");
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

    class Customer
    {
        public void Model2022(IFactory Factory)
        {
            ICar Car = Factory.ProduceCar();
            Car.Model2022();
        }

        public void Model2023(IFactory Factory)
        {
            ICar Car = Factory.ProduceCar();
            Car.Model2023();
        }
    }

    class Program
    {
        static void Main()
        {
            Customer Customer = new Customer();
            
            IFactory DodgeFactory = new DodgeFactory();
            Customer.Model2022(DodgeFactory);

            IFactory FordFactory = new FordFactory();
            Customer.Model2023(FordFactory);
        }
    }
}