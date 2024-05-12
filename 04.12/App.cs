using System;
using System.Text;

namespace cSharpAdvancedConsole._04._12
{
  public class App
  {
    public static void Run()
    {
      Console.OutputEncoding = Encoding.UTF8;
      int eingabe = -1;
      int schaden;
      Random rnd = new Random();

      Spieler spieler = new Spieler("peter", 100);
      Computer bot = new Computer("bot", 100);

      do
      {
        do
        {
          Console.WriteLine("Bitte Attacke wählen");
          Console.WriteLine("[0] Schielen");
          Console.WriteLine("[1] Grimasse");

          eingabe = Convert.ToInt32(Console.ReadLine());
          if (eingabe != 0 && eingabe != 1)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nUngültige Eingabe !!!!\n");
            Console.ResetColor();
          }
        } while (eingabe != 0 && eingabe != 1);

        switch (eingabe)
        {
          case 0:
            schaden = spieler.Schielen();
            bot.lebenspunkte -= schaden;

            Console.WriteLine($"\nSpieler verursacht {schaden} Schaden👊🧨🩻⚔️🗡️🏹🔫🔪");
            if (bot.lebenspunkte > 0)
            {
              Console.WriteLine($"Bot Lebenspunkte: {bot.lebenspunkte}♥️");
            }

            break;
          case 1:
            schaden = spieler.Grimasse();
            bot.lebenspunkte -= schaden;
            Console.WriteLine($"\nSpieler verursacht {schaden} Schaden👊🧨🩻⚔️🗡️🏹🔫🔪");
            if (bot.lebenspunkte > 0)
            {
              Console.WriteLine($"Bot Lebenspunkte: {bot.lebenspunkte}♥️");
            }

            break;
        }

        eingabe = rnd.Next(0, 2);
        if (bot.lebenspunkte <= 0)
        {
          break;
        }

        switch (eingabe)
        {
          case 0:
            schaden = bot.Normal();
            spieler.lebenspunkte -= schaden;
            Console.WriteLine($"\nComputer verursacht {schaden} Schaden👊🧨🩻⚔️🗡️🏹🔫🔪");
            if (spieler.lebenspunkte > 0)
            {
              Console.WriteLine($"Spieler Lebenspunkte: {spieler.lebenspunkte}♥️\n");
            }

            break;
          case 1:
            schaden = bot.Super();
            spieler.lebenspunkte -= schaden;
            Console.WriteLine($"\nComputer verursacht {schaden} Schaden👊🧨🩻⚔️🗡️🏹🔫🔪");
            if (spieler.lebenspunkte > 0)
            {
              Console.WriteLine($"Spieler Lebenspunkte: {spieler.lebenspunkte}♥️\n");
            }

            break;
        }
      } while (spieler.lebenspunkte > 0 || bot.lebenspunkte > 0);


      if (spieler.lebenspunkte <= 0 && bot.lebenspunkte > 0)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n*********");
        Console.WriteLine("You lose!🫷💀🫸☠️⚰️️🚽🪠🧻😵🥴💩🙈🦴🚾⛔🆘 ");
        Console.WriteLine("*********");
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n********");
        Console.WriteLine("You win!✌️🏅💪👍🥇💰🎉🎗️🎁🍾🍻🆒 ");
        Console.WriteLine("********");
      }
    }
  }
}