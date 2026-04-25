namespace DesignPatterns.Mediator
{
  public class Runway
  {
    public readonly Guid Id = Guid.NewGuid();
    public CommandCentre? Mediator;

    public bool CheckIsActive()
        {
                       return Mediator!.CheckIsActiveRequest(this);
        }

        public void HighLightRed()
    {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Runway {this.Id} is busy!");
            Console.ResetColor();
    }

    public void HighLightGreen()
    {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Runway {this.Id} is free!");
            Console.ResetColor();
    }
  }
}