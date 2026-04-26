using ClassLibraryStructurePatterns.Decorator.Characters;

namespace ClassLibraryStructurePatterns.Decorator.Inventory
{
    public class Artefact : InventoryDecorator
    {
        public Artefact(ICharacter character) : base(character) { }

        public override string GetDescription() => _character.GetDescription() + " з артефактом";
        public override int GetAttack() => _character.GetAttack() + 10;
        public override int GetDefence() => _character.GetDefence() + 30;
        public override int GetMagic() => _character.GetMagic() + 50;
    }
}
