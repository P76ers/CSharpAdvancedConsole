namespace cSharpAdvancedConsole.Aufgaben.Inheritance2
{
  public class Program
  {
    public static void Run(string[] args)
    {
      Auto auto = new Auto("Audi", "A8", 260);
      auto.Fahren();
      auto.FahrzeugInfo();
      
      Motorrad motorrad = new Motorrad("Harley Davidson", "Fat Bob", 240);
      motorrad.Fahren();
      motorrad.FahrzeugInfo();
    }
  }
}