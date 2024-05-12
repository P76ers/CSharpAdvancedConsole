using System;

namespace cSharpAdvancedConsole._04._16.Fahrzeug
{
  public class Wasserfahrzeug : Fahrzeug
  {
    private int tiefgang;

    public Wasserfahrzeug(string name, int geschwindigkeit, int tiefgang) : base(name, geschwindigkeit)
    {
      fahrzeuge.Add(this);
      this.tiefgang = tiefgang;
    }

    public int Tiefgang
    {
      get => tiefgang;
      set => tiefgang = value;
    }

    public override void Fahren()
    {
      Console.WriteLine($"{this.name} schwimmt mit {this.geschwindigkeit} Knoten");
    }
  }
}