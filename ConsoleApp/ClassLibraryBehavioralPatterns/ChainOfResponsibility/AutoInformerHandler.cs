namespace ClassLibraryBehavioralPatterns.ChainOfResponsibility
{
    public class AutoInformerHandler : BaseHandler
    {
        public override void Handle()
        { 
            Console.WriteLine("Вас цікавить інформація про Ваш баланс? (y/n)");
            Console.Write(">>> ");

            string? answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine(">>> Ваш баланс становить 150 грн. Гарного дня!");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
