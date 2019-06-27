using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Game director = new Game();
            List<CharacterBuilder> builders = new List<CharacterBuilder>
            {
                new WitchBuilder(),
                new WizardBuilder(),
                new WitchBuilder()
            };

            foreach(var b in builders)
            {
                director.Construct(b);
                var c = b.GetCharacter();
                c.Show();
            }

            Console.ReadLine();
        }
    }
}
