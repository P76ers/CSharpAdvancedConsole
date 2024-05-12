namespace cSharpAdvancedConsole.Aufgaben.Inheritance
{
  public abstract class Humanoid
  {
    public string name;

    public Humanoid(string name)
    {
      this.name = name;
    }

    public abstract void Steckbrief();
  }
}