namespace ClassLibraryStructurePatterns.Decorator.Characters
{
    public class Warrior : ICharacter
    {
        public string GetDescription() => "Воїн";
        public int GetAttack() => 30;
        public int GetDefence() => 30;
        public int GetMagic() => 5;
    }
}
