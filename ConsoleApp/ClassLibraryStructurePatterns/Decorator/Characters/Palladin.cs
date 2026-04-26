namespace ClassLibraryStructurePatterns.Decorator.Characters
{
    public class Palladin : ICharacter
    {
        public string GetDescription() => "Паладин";
        public int GetAttack() => 45;
        public int GetDefence() => 20;
        public int GetMagic() => 15;
    }
}
