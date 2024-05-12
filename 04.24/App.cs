using System;

namespace cSharpAdvancedConsole._04._24
{
  public class App
  {
    public static void Run()
    {
      int eingabe;

      try
      {
        Console.WriteLine("Zahl < 10 eingeben für Exception...");
        eingabe = Convert.ToInt32(Console.ReadLine());

        if (eingabe < 10)

        {
          throw new FehlerError("Falsche Eingabe!");
        }
      }
      catch (FehlerError e)
      {
        Console.WriteLine(e);
        throw;
      }


      // ----------
      Auto auto;

      try
      {
        // Console.WriteLine(auto.name);
      }
      catch (NullReferenceException e)
      {
        Console.WriteLine(e);
      }

      //
      int[] werte = new int[2];
      try
      {
        Console.WriteLine(werte[3]);
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}