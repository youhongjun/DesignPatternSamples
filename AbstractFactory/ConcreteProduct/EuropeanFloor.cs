using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class EuropeanFloor : IFloor
    {
        public void Display()
        {
            Console.WriteLine("European floor...");
        }
    }
}
