using ClassLibraryBehavioralPatterns.ChainOfResponsibility;

namespace ClassLibraryBehavioralPatterns
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler? _handler;

        public IHandler SetNext(IHandler handler)
        {
            _handler = handler;
            return handler;
        }

        public virtual void Handle()
        {
            if (_handler != null)
            {
                _handler.Handle();
            } 
            
            else
            {
                Console.WriteLine("На жаль, ми не знайшли відповідного спеціаліста. Починаємо спочатку...");
            }
        }
    }
}
