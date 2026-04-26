namespace ClassLibraryBehavioralPatterns.Observer
{
    public class ConsoleEventListener : IEventListener
    {
        public void Update(string eventName, object sender)
        {
            Console.WriteLine($"Подія '{eventName}' відбулася у об'єкті {sender}");
        }
    }
}
