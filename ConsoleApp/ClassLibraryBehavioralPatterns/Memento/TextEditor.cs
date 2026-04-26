using System.Text;
namespace ClassLibraryBehavioralPatterns.Memento
{
    public class TextEditor
    {
        private StringBuilder _state = new StringBuilder();

        public IMemento CreateShapshot()
        {
            TextDocument document = new TextDocument(_state.ToString(), DateTime.Now);
            return document;
        }

        public void Restore(IMemento memento)
        {
            if (memento is TextDocument document)
            {
                this._state = new StringBuilder(document.GetText());
            }
        }

        public void Write(string text) => _state.Append(text);
        public string? GetContent() => _state.ToString();
    }
}
