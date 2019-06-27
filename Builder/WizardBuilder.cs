using System;
namespace Builder
{
    public class WizardBuilder : CharacterBuilder
    {
        public WizardBuilder()
        {
            _character = new GameCharacter("Wizard");
        }

        public override void BuildBody()
        {
            _character.Body = "Wizard body";
        }

        public override void BuildCostume()
        {
            _character.Costume = "Wizard costume";
        }

        public override void BuildFace()
        {
            _character.Face = "Wizard face";
        }
    }
}
