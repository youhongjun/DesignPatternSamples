using System;
namespace Adapter
{
    /// <summary>
    /// Target
    /// </summary>
    public class Service
    {
        public virtual void GetHealth(string characterName)
        {
            Console.WriteLine($"Health of {characterName}:");
        }
    }
}
