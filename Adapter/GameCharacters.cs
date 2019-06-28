using System;
using System.Collections.Generic;
using System.Linq;

namespace Adapter
{
    /// <summary>
    /// Adaptee
    /// </summary>
    public class GameCharacters
    {
        List<Character> characters = new List<Character>
        {
            new Character { Name="Witch", Health=800 },
            new Character { Name="Wizard", Health=500 },
            new Character { Name="Miner", Health=1300 }
        };

        public int GetHealth(string characterName)
        {
            var character = characters.Where(c => c.Name == characterName).FirstOrDefault();
            return (character != null) ? character.Health : 0;
        }
    }
}
