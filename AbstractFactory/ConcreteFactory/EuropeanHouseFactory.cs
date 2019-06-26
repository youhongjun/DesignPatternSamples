using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
namespace AbstractFactory.ConcreteFactory
{
    public class EuropeanHouseFactory : IHouseFactory
    {
        public ICeiling CreateCeiling()
        {
            return new EuropeanCeiling();
        }

        public IDoor CreateDoor()
        {
            return new EuropeanDoor();
        }

        public IFloor CreateFloor()
        {
            return new EuropeanFloor();
        }

        public IWall CreateWall()
        {
            return new EuropeanWall();
        }

        public IWindow CreateWindow()
        {
            return new EuropeanWindow();
        }
    }
}
