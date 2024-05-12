namespace cSharpAdvancedConsole._04._16.Fahrzeug
{
  public class App
  {
    public static void Run()
    {
      Landfahrzeug terry = new Landfahrzeug("terry", 120, 4);
      Wasserfahrzeug maritim = new Wasserfahrzeug("Aqua", 25, 12);

      foreach (Fahrzeug fahrzeug in Fahrzeug.fahrzeuge)
      {
        fahrzeug.Fahren();
      }
    }
  }
}