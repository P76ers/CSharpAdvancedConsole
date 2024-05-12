using System;

namespace cSharpAdvancedConsole._04._15
{
  public class App
  {
    public static void Run()
    {
      int eingabe;
      Entity player;
      Entity enemy = new Mage();

      Console.WriteLine("Bitte Kampfklasse wählen:");
      Console.WriteLine("[1]: Krieger");
      Console.WriteLine("[2]: Magier");

      // eingabe = Convert.ToInt32(Console.ReadLine());
      //
      // switch (eingabe)
      // {
      //   case 1:
      //     player = new Warrior(200,100);
      //     break;
      //   
      //   case 2:
      //     player = new Mage(100,200);
      //     break;
      // }

      player = new Warrior("Spielah", 200);
      enemy = new Mage("Bot", 200);

      player.NormalAttack(enemy);
      enemy.SpecialAttack(player);
    }
  }
}