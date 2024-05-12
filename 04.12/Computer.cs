using System;

namespace cSharpAdvancedConsole._04._12
{
  public class Computer
  {
    public string name;
    public int lebenspunkte;
    Random rnd = new Random();

    public Computer()
    {
    }

    public Computer(string name, int lebenspunkte)
    {
      this.name = name;
      this.lebenspunkte = lebenspunkte;
    }

    public int Normal()
    {
      return rnd.Next(10, 20);
    }

    public int Super()
    {
      return rnd.Next(2, 30);
    }
  }
}