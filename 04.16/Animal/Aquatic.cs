using System;

namespace cSharpAdvancedConsole._04._16.Animal
{
  public class Aquatic : Animal, IEatable
  {
    private int divingTime;

    public Aquatic(string name, int age, Gender gender) : base(name, age, gender)
    {
    }

    public override void Move()
    {
      Console.WriteLine($"{this.name} is swimming");
    }

    public void Eatable()
    {
      Console.WriteLine($"{this.name} is eatable");
    }

    public int DivingTime
    {
      get => divingTime;
      set => divingTime = value;
    }
  }
}