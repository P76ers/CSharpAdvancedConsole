using System;

namespace cSharpAdvancedConsole._04._16.Animal
{
  public class Terrestrial : Animal
  {
    public Terrestrial(string name, int age, Gender gender) : base(name, age, gender)
    {
    }

    public override void Move()
    {
      Console.WriteLine($"{this.name} runs");
    }
  }
}