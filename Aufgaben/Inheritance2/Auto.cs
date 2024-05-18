using System;

namespace cSharpAdvancedConsole.Aufgaben.Inheritance2
{
  public class Auto : Fahrzeug, IFahrbar
  {
    public Auto(string marke, string modell, int hoechstgeschwindigkeit) : base(marke, modell, hoechstgeschwindigkeit)
    {
    }

    public override void FahrzeugInfo()
    {
      Console.WriteLine($"Auto-Marke: {marke}");
      Console.WriteLine($"Auto-Modell: {modell}");
      Console.WriteLine($"Auto-Hoechstgeschwindigkeit: {hoechstgeschwindigkeit}");
    }

    public void Fahren()
    {
      Console.WriteLine($"Das Auto fährt");
    }
  }
}