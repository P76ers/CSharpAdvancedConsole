using System;

namespace cSharpAdvancedConsole.Aufgaben.Taschenrechner
{
  public class Taschenrechner
  {
    public static void Run()
    {
      int x = 57, y = 3, erg = 0;
      char rechenArt = '%';

      switch (rechenArt)
      {
        case '+':
          erg = x + y;
          break;
        case '-':
          erg = x - y;
          break;
        case '*':
          erg = x * y;
          break;
        case '/':
          erg = x / y;
          break;
        case '%':
          erg = x % y;
          break;
      }

      Console.WriteLine(erg);
    }
  }
}