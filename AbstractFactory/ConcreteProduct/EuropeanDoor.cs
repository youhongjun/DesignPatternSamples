using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class EuropeanDoor : IDoor
    {
        public void Display()
        {
            Console.WriteLine("European door...");
        }
    }
}
