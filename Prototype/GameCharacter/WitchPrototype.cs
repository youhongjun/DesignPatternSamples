using System;
namespace Prototype.GameCharacter
{
    public class WitchPrototype : GameCharacterPrototype
    {
        public WitchPrototype(int health)
        {
            Health = health;
        }

        public override GameCharacterPrototype Clone()
        {
            Console.WriteLine($"Witch health is {Health}");
            return MemberwiseClone() as GameCharacterPrototype;
        }
    }
}
