namespace ClassLibraryStructurePatterns.Decorator.Characters
{
    public class Mage : ICharacter
    {
        public string GetDescription() => "Маг";
        public int GetAttack() => 60;
        public int GetDefence() => 50;
        public int GetMagic() => 80;
    }
}
