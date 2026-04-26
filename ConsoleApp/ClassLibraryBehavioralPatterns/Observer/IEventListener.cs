namespace ClassLibraryBehavioralPatterns.Observer
{
    public interface IEventListener
    {
        void Update(string eventName, object sender);
    }
}
