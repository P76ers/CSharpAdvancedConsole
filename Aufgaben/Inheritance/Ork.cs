using System;

namespace cSharpAdvancedConsole.Aufgaben.Inheritance
{
  public class Ork : Humanoid, IGrobig
  {
    public bool GROBIG { get; set; }


    public Ork(string name, bool grobig) : base(name)
    {
      GROBIG = grobig;
    }

    public override void Steckbrief()
    {
      Console.WriteLine($"{this.name} ist grobig={this.GROBIG}");
    }
  }
}