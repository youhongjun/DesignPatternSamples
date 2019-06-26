using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class EuropeanWindow : IWindow
    {
        public void Display()
        {
            Console.WriteLine("European window...");
        }
    }
}
