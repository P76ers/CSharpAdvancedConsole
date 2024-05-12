using System;

namespace cSharpAdvancedConsole._04._16.Animal
{
  public class Flying : Animal
  {
    public Flying(string name, int age, Gender gender) : base(name, age, gender)
    {
    }

    public override void Move()
    {
      Console.WriteLine($"{this.name} is flying");
    }
  }
}