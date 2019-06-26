using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class AsianCeiling : ICeiling
    {
        public void Display()
        {
            Console.WriteLine("Asian ceiling...");
        }
    }
}
