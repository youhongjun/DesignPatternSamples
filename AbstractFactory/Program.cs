using System;
using System.Collections.Generic;

using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IHouseFactory> houseFactories = new List<IHouseFactory> {
                new AsianHouseFactory(),
                new EuropeanHouseFactory()
            };
            foreach (var factory in houseFactories)
            {
                Build(factory);
            }

            Console.ReadLine();
        }

        static void Build(IHouseFactory factory)
        {
            IFloor floor = factory.CreateFloor();
            IWall wall = factory.CreateWall();
            IDoor door = factory.CreateDoor();
            IWindow window = factory.CreateWindow();
            ICeiling ceiling = factory.CreateCeiling();

            floor.Display();
            wall.Display();
            door.Display();
            window.Display();
            ceiling.Display();
        }
    }
}
