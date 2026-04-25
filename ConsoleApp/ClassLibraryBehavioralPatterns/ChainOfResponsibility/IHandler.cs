namespace ClassLibraryBehavioralPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler hnadler);
        void Handle();
    }
}
