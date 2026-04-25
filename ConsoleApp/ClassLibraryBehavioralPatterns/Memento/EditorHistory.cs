namespace ClassLibraryBehavioralPatterns.Memento
{
    public class EditorHistory
    {
        private TextEditor _editor;
        public Stack<IMemento> _history = new Stack<IMemento>();

        public EditorHistory(TextEditor editor)
        {
            _editor = editor;
        }

        public void Save()
        {
            _history.Push(_editor.CreateShapshot());
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _editor.Restore(memento);
            }
        }
    }
}
