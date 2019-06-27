using System;
namespace Builder
{
    public class WitchBuilder : CharacterBuilder
    {
        public WitchBuilder()
        {
            _character = new GameCharacter("Witch");
        }

        public override void BuildBody()
        {
            _character.Body = "Witch body";
        }

        public override void BuildCostume()
        {
            _character.Costume = "Witch costume";
        }

        public override void BuildFace()
        {
            _character.Face = "Witch face";
        }
    }
}
