namespace DesignPatterns.Mediator
{
  public class Aircraft
  {
    public string Name;
    public CommandCentre? Mediator;
    public Aircraft(string name, int size)
    {
      this.Name = name;
    }

    public void Land()
    {
      Mediator!.RequestLanding(this);
    }

    public void TakeOff()
    {
      Mediator!.RequestTakeOff(this);
    }
  }
}