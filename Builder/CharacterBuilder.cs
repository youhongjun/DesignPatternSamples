using System;
namespace Builder
{
    public abstract class CharacterBuilder
    {
        protected GameCharacter _character;

        public GameCharacter GetCharacter()
        {
            return _character;
        }

        public abstract void BuildFace();
        public abstract void BuildBody();
        public abstract void BuildCostume();
    }
}
