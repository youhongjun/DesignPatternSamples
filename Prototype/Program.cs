using System;
using Prototype.GameCharacter;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacterManager characterManager = new GameCharacterManager();
            characterManager["Wizard1"] = new WizardPrototype(500);
            characterManager["Witch1"] = new WizardPrototype(800);

            WizardPrototype wizard2 = characterManager["Wizard1"].Clone() as WizardPrototype;
            WitchPrototype witch2 = characterManager["Witch1"].Clone() as WitchPrototype;

            Console.WriteLine("Is same wizard：{0}", ReferenceEquals(wizard2, characterManager["Wizard1"]));
            Console.WriteLine("Is same witch：{0}", ReferenceEquals(witch2, characterManager["Witch1"]));

            Console.ReadKey();
        }
    }
}
