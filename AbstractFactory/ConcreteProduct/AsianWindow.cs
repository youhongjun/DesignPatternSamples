using System;
using AbstractFactory.AbstractProduct;
namespace AbstractFactory.ConcreteProduct
{
    public class AsianWindow : IWindow
    {
        public void Display()
        {
            Console.WriteLine("Asian window...");
        }
    }
}
