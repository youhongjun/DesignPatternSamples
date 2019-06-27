using System;
namespace Builder
{
    public class Game
    {
        public void Construct(CharacterBuilder builder)
        {
            builder.BuildFace();
            builder.BuildBody();
            builder.BuildCostume();
        }
    }
}
