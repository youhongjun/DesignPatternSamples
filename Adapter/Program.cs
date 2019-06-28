using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Service s = new CharacterService();
            s.GetHealth("Witch");
            s.GetHealth("Wizard");
            s.GetHealth("Miner");

            Console.ReadKey();
        }
    }
}
