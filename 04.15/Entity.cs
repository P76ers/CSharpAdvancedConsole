using System;

namespace cSharpAdvancedConsole._04._15
{
  public class Entity
  {
    public string name;
    public int lifePoint;
    public int damage;
    protected Random rnd = new Random();

    protected Entity()
    {
    }

    protected Entity(string name, int lifePoint)
    {
      this.name = name;
      this.lifePoint = lifePoint;
    }

    public virtual void NormalAttack(Entity entity)
    {
      Console.WriteLine("NormalAttack");
    }

    public virtual void SpecialAttack(Entity entity)
    {
      Console.WriteLine("SpecialAttack");
    }
  }
}