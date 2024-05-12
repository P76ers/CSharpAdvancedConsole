using System;

namespace cSharpAdvancedConsole._04._12
{
  public class Spieler
  {
    public string name;
    public int lebenspunkte;

    Random rnd = new Random();

    public Spieler()
    {
    }

    public Spieler(string name, int lebenspunkte)
    {
      this.name = name;
      this.lebenspunkte = lebenspunkte;
    }


    public int Schielen()
    {
      return rnd.Next(10, 20);
    }

    public int Grimasse()
    {
      return rnd.Next(2, 30);
    }
  }
}