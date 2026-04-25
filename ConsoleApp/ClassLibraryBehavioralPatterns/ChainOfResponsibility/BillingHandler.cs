namespace ClassLibraryBehavioralPatterns.ChainOfResponsibility
{
    public class BillingHandler : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Ви дійсно хочете здійнити операцію оплати? (y/n)");
            Console.Write(">>> ");

            string? answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine(">>> Ви оплатили 150 грн");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
