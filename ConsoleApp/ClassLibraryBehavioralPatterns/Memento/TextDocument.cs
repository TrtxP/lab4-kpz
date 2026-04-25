namespace ClassLibraryBehavioralPatterns.Memento
{
    public class TextDocument : IMemento
    {
        private readonly string? _text;
        private readonly DateTime _editDate;

        public TextDocument(string? text, DateTime editDate)
        {
            _text = text;
            _editDate = editDate;
        }

        public string? GetText() => _text;
        public DateTime GetEditDate() => _editDate;
    }
}
