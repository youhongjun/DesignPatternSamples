using System;
namespace Prototype.GameCharacter
{
    public abstract class GameCharacterPrototype
    {
        protected int Health { get; set; }
        public abstract GameCharacterPrototype Clone();
    }
}
