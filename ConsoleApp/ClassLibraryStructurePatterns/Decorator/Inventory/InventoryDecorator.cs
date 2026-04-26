using ClassLibraryStructurePatterns.Decorator.Characters;

namespace ClassLibraryStructurePatterns.Decorator.Inventory
{
    public abstract class InventoryDecorator : ICharacter
    {
        protected ICharacter _character;

        public InventoryDecorator(ICharacter character)
        {
            _character = character;
        }

        public virtual string GetDescription() => _character.GetDescription();
        public virtual int GetAttack() => _character.GetAttack();
        public virtual int GetDefence() => _character.GetDefence();
        public virtual int GetMagic() => _character.GetMagic();
    }
}
