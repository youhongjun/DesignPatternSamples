using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class AsianDoor : IDoor
    {
        public void Display()
        {
            Console.WriteLine("Asian door...");
        }
    }
}
