using System;
namespace Prototype.GameCharacter
{
    public class WizardPrototype : GameCharacterPrototype
    {
        public WizardPrototype(int health)
        {
            Health = health;
        }

        public override GameCharacterPrototype Clone()
        {
            Console.WriteLine($"Wizard health is {Health}");
            return MemberwiseClone() as GameCharacterPrototype;
        }
    }
}
