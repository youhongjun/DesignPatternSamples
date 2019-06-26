using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class AsianWall : IWall
    {
        public void Display()
        {
            Console.WriteLine("Asian wall...");
        }
    }
}
