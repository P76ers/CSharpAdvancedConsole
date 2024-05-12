using System;

namespace cSharpAdvancedConsole.Aufgaben.ZinsesZinsRechner
{
  public class ZinsesZinsRechner
  {
    public static void Run()
    {
      double startkapital, endKapital = 0;
      int zinsSatz;

      Console.Write("Startkapital: ");
      startkapital = Convert.ToDouble(Console.ReadLine());
      Console.Write("Zinssatz: ");
      zinsSatz = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < 3; i++)
      {
        endKapital = startkapital + (startkapital * 5 / 100);
        startkapital = endKapital;
      }

      Console.WriteLine(endKapital);
    }
  }
}