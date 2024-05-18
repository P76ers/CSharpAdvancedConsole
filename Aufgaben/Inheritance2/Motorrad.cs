using System;

namespace cSharpAdvancedConsole.Aufgaben.Inheritance2
{
  public class Motorrad : Fahrzeug, IFahrbar
  {
    public Motorrad(string marke, string modell, int hoechstgeschwindigkeit) : base(marke, modell, hoechstgeschwindigkeit)
    {
    }

    public override void FahrzeugInfo()
    {
      Console.WriteLine($"Motorrad-Marke: {marke}");
      Console.WriteLine($"Motorrad-Modell: {modell}");
      Console.WriteLine($"Motorrad-Hoechstgeschwindigkeit: {hoechstgeschwindigkeit}");
    }

    public void Fahren()
    {
      Console.WriteLine("Das Motorrad fährt");
    }
  }
}