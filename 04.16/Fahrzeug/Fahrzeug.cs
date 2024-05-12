using System;
using System.Collections.Generic;

namespace cSharpAdvancedConsole._04._16.Fahrzeug
{
  public class Fahrzeug
  {
    protected string name;
    protected int geschwindigkeit;
    public static List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();


    public Fahrzeug()
    {
    }

    public Fahrzeug(string name, int geschwindigkeit)
    {
      fahrzeuge.Add(this);
      this.geschwindigkeit = geschwindigkeit;
    }

    public virtual void Fahren()
    {
      Console.WriteLine($"Könnte sich bewegen");
    }

    public string Name
    {
      get => name;
      set => name = value;
    }

    public int Geschwindigkeit
    {
      get => geschwindigkeit;
      set => geschwindigkeit = value;
    }
  }
}