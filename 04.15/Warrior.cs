using System;

namespace cSharpAdvancedConsole._04._15
{
  public class Warrior : Entity
  {
    public Warrior()
    {
    }

    public Warrior(string name, int lifePoint) : base(name, lifePoint)
    {
    }

    public override void NormalAttack(Entity entity)
    {
      damage = rnd.Next(10, 20);
      Console.WriteLine($"\n{this.name} uses Charge und causes {damage} Damage on {entity.name}");
      Console.WriteLine($"{entity.name} Lifepoints: {entity.lifePoint - damage}\n");
    }

    public override void SpecialAttack(Entity entity)
    {
      damage = rnd.Next(5, 30);
      Console.WriteLine($"\n{this.name} uses Execute und causes {damage} Damage on {entity.name}");
      Console.WriteLine($"{entity.name} Lifepoints: {entity.lifePoint - damage}\n");
    }
  }
}