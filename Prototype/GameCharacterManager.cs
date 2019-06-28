using System;
using System.Collections.Generic;
using Prototype.GameCharacter;

namespace Prototype
{
    public class GameCharacterManager
    {
        private Dictionary<string, GameCharacterPrototype> _characters = new Dictionary<string, GameCharacterPrototype>();

        public GameCharacterPrototype this[string key]
        {
            get { return _characters[key]; }
            set { _characters.Add(key, value); }
        }
    }
}
