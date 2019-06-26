using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public interface IHouseFactory
    {
        IFloor CreateFloor();
        IWall CreateWall();
        IDoor CreateDoor();
        IWindow CreateWindow();
        ICeiling CreateCeiling();
    }
}
