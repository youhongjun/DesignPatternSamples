using System;
namespace Builder
{
    public class GameCharacter
    {
        private string _name;
        public GameCharacter(string name)
        {
            _name = name;
        }

        public string Face { get; set; }
        public string Body { get; set; }
        public string Costume { get; set; }

        public void Show()
        {
            Console.WriteLine($"{_name}: {Face} {Body} {Costume}");
        }
    }
}
