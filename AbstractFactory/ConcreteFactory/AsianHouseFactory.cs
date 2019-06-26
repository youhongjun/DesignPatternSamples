using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
namespace AbstractFactory.ConcreteFactory
{
    public class AsianHouseFactory : IHouseFactory
    {
        public ICeiling CreateCeiling()
        {
            return new AsianCeiling();
        }

        public IDoor CreateDoor()
        {
            return new AsianDoor();
        }

        public IFloor CreateFloor()
        {
            return new AsianFloor();
        }

        public IWall CreateWall()
        {
            return new AsianWall();
        }

        public IWindow CreateWindow()
        {
            return new AsianWindow();
        }
    }
}
