using ClassLibraryStructurePatterns.Decorator.Characters;

namespace ClassLibraryStructurePatterns.Decorator.Inventory
{
    public class Clothing : InventoryDecorator
    {
        public Clothing(ICharacter character) : base(character) { }

        public override string GetDescription() => _character.GetDescription() + " з одягом";
        public override int GetAttack() => _character.GetAttack();
        public override int GetDefence() => _character.GetDefence() + 50;
        public override int GetMagic() => _character.GetMagic();
    }
}
