namespace DesignPatterns.Mediator
{
  public class CommandCentre
  {
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();
    private Dictionary<Aircraft, Runway> _activePlanes = new Dictionary<Aircraft, Runway>();

    public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
    {
      foreach (var runway in runways)
      {
        runway.Mediator = this;
        _runways.Add(runway);
      }
      
      foreach (var aircraft in aircrafts)
      {
        aircraft.Mediator = this; 
        _aircrafts.Add(aircraft);
      }
    }

    public void RequestLanding(Aircraft aircraft)
    {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing");
            Console.WriteLine("Checking runway");

            bool found = false; 

            foreach (var runway in _runways)
            {
                if (!_activePlanes.ContainsValue(runway))
                {
                    _activePlanes[aircraft] = runway;
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed");
                    runway.HighLightRed();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Could not land, the runway is busy.");
            }
    }

    public void RequestTakeOff(Aircraft aircraft)
    {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");

            if (_activePlanes.TryGetValue(aircraft, out var runway))
            {
                _activePlanes.Remove(aircraft);
                runway.HighLightGreen();
                Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
            }
    }

    public bool CheckIsActiveRequest(Runway runway)
    {
            return _activePlanes.ContainsValue(runway);
    }
  }
}