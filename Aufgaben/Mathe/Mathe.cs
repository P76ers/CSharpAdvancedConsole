using System;

namespace cSharpAdvancedConsole.Aufgaben.Mathe
{
  public class Mathe
  {
    public static void Run()
    {
      Fakultaet(5);
    }

    public static double Addieren(double x, double y)
    {
      return x + y;
    }

    public static double Subtrahieren(double x, double y)
    {
      return x - y;
    }

    public static double Potenz(double x, double y)
    {
      return Math.Pow(x, y);
    }

    public static int Fakultaet(int x)
    {
      for (int i = x - 1; i > 1; i--)
      {
        x *= i;
      }

      Console.WriteLine(x);
      return x;
    }
  }
}