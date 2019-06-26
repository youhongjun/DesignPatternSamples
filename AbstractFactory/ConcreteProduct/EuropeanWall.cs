using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class EuropeanWall : IWall
    {
        public void Display()
        {
            Console.WriteLine("European wall...");
        }
    }
}
