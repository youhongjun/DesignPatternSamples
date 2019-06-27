using System;
using System.Collections.Generic;
using FactoryMethod.Websites;


namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> sites = new List<Website>
            {
                new CompanyWebsite(),
                new PersonalWebsite()
            };

            foreach(var s in sites)
            {
                Console.WriteLine(s.GetType().Name + ":");
                foreach(var p in s.WebPages)
                {
                    Console.WriteLine("-" + p.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
