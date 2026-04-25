namespace ClassLibraryBehavioralPatterns.Observer
{
    public class EventTarget
    {
        public Dictionary<string, List<IEventListener>> _eventListeners = new Dictionary<string, List<IEventListener>>();

        public void AddEventListener(string eventName, IEventListener listener)
        {
            if (!_eventListeners.ContainsKey(eventName))
            {
                _eventListeners[eventName] = new List<IEventListener>();
            }
            _eventListeners[eventName].Add(listener);
        }

        public void DispatchEvent(string eventName)
        {
            if (_eventListeners.TryGetValue(eventName, out var listeners))
            {
                foreach (var listener in listeners)
                {
                    listener.Update();
                }
            }
        }
    }
}
