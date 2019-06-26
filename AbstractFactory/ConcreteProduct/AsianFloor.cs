using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class AsianFloor : IFloor
    {
        public void Display()
        {
            Console.WriteLine("Asian floor...");
        }
    }
}
