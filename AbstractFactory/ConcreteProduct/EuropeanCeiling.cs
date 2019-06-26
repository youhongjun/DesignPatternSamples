using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class EuropeanCeiling : ICeiling
    {
        public void Display()
        {
            Console.WriteLine("European ceiling...");
        }
    }
}
