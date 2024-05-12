using System;

namespace cSharpAdvancedConsole._04._16.Fahrzeug
{
  public class Landfahrzeug : Fahrzeug, IAbschleppbar
  {
    private int raeder;

    public Landfahrzeug(string name, int geschwindigkeit, int raeder) : base(name, geschwindigkeit)
    {
      fahrzeuge.Add(this);
      this.raeder = raeder;
    }

    public void Abschleppbar()
    {
      Console.WriteLine($"{this.name} wird abgeschleppt");
    }

    public override void Fahren()
    {
      Console.WriteLine($"{this.name} fährt auf {this.raeder} Rädern");
    }
  }
}