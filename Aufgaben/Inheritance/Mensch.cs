using System;

namespace cSharpAdvancedConsole.Aufgaben.Inheritance
{
  public class Mensch : Humanoid, IGeschmeidig
  {
    public bool GESCHMEIDIG { get; set; }

    public Mensch(string name, bool geschmeidig) : base(name)
    {
      GESCHMEIDIG = geschmeidig;
    }


    public override void Steckbrief()
    {
      Console.WriteLine($"{this.name} ist geschmeidig={this.GESCHMEIDIG}");
    }
  }
}