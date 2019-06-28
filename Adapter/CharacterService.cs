using System;
namespace Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class CharacterService : Service
    {
        public override void GetHealth(string characterName)
        {
            base.GetHealth(characterName);
            GameCharacters gameCharacters = new GameCharacters();
            int health = gameCharacters.GetHealth(characterName);
            Console.WriteLine(health.ToString());
        }
    }
}
