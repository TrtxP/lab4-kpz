namespace ClassLibraryBehavioralPatterns.ChainOfResponsibility
{
    public class TechHandler : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Ви дійсно хочете дізнатися свій пакет інтернету? (y/n)");
            Console.Write(">>> ");

            string? answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine(">>> Ваш пакет інтернету 23 гігабайти");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
