using System;

namespace cSharpAdvancedConsole._04._16.Animal
{
  public class Animal
  {
    protected string name;
    protected int age;
    protected Gender gender = Gender.NONE;

    public Animal()
    {
    }

    public Animal(string name, int age, Gender gender)
    {
      this.name = name;
      this.age = age;
      this.gender = gender;
    }

    #region Getter/Setter

    public string Name
    {
      get => name;
      set => name = value;
    }

    public int GetAge()
    {
      return age;
    }

    public void SetAge(int age)
    {
      this.age = age;
    }

    #endregion

    public virtual void Move()
    {
    }

    public virtual void Eat()
    {
      Console.WriteLine($"{this.name} is eating");
    }
  }
}