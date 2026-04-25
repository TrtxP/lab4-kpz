namespace ClassLibraryBehavioralPatterns.ChainOfResponsibility
{
    public class ExpertHandler : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Ви дійсно хочете звернутися до спеціаліста? (y/n)");
            Console.Write(">>> ");

            string? answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine(">>> Ви звернулися до спеціаліста Івана Миколайовича");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
