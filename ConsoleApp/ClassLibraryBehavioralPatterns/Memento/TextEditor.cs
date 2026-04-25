namespace ClassLibraryBehavioralPatterns.Memento
{
    public class TextEditor
    {
        private string? _state;

        public IMemento CreateShapshot()
        {
            TextDocument document = new TextDocument(_state, DateTime.Now);
            return document;
        }

        public void Restore(IMemento memento)
        {
            if (memento is TextDocument document)
            {
                this._state = document.GetText();
                Console.WriteLine($"Відновлено текст: {this._state}");
            }
        }

        public void Write(string text) => _state = text;
        public string? GetContent() => _state;
    }
}
