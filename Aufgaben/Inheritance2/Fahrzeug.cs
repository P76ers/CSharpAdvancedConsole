namespace cSharpAdvancedConsole.Aufgaben.Inheritance2
{
  public abstract class Fahrzeug
  {
    public string marke;
    public string modell;
    public int hoechstgeschwindigkeit;

    public abstract void FahrzeugInfo();

    public Fahrzeug(string marke, string modell, int hoechstgeschwindigkeit)
    {
      this.marke = marke;
      this.modell = modell;
      this.hoechstgeschwindigkeit = hoechstgeschwindigkeit;
    }
  }
}