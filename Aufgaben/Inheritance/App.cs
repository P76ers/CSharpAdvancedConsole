namespace cSharpAdvancedConsole.Aufgaben.Inheritance
{
  public class App
  {
    public static void Run()
    {
      Ork ork = new Ork("Grunzer", true);
      Mensch mensch = new Mensch("P", true);

      ork.Steckbrief();
      mensch.Steckbrief();
    }
  }
}