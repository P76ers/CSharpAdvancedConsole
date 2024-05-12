using System;

namespace cSharpAdvancedConsole._04._11
{
  public class Menu
  {
    public static int eingabe;

    public static void Hauptmenu()
    {
      Console.WriteLine("[1]: Computer erstellen");
      Console.WriteLine("[0]: App beenden");

      eingabe = Convert.ToInt32(Console.ReadLine());

      switch (eingabe)
      {
        case 1:
          ComputerErstellen();
          break;
        case 0:
          Environment.Exit(0);
          break;
      }
    }

    public static void ComputerErstellen()
    {
      Computer computer;
      CPU cpu = new CPU();
      int ram = 0;
      int eingabe = 0;

      CpuList.addCPU();

      Console.WriteLine("CPU Hersteller wählen: ");
      Console.WriteLine("[0]: Intel ");
      Console.WriteLine("[1]: AMD ");

      eingabe = Convert.ToInt32(Console.ReadLine());

      if (eingabe == 0)
      {
        cpu.SetHersteller(CpuList.allCPUs[0].GetHersteller());
      }
      else if (eingabe == 1)
      {
        cpu.SetHersteller(CpuList.allCPUs[1].GetHersteller());
      }

      Console.WriteLine(cpu.GetHersteller());

      Console.WriteLine("Arbeitsspeicher wählen");
      Console.WriteLine("[0]: 16GB ");
      Console.WriteLine("[1]: 32GB ");

      eingabe = Convert.ToInt32(Console.ReadLine());

      if (eingabe == 0)
      {
        ram = 16;
      }
      else if (eingabe == 1)
      {
        ram = 32;
      }

      computer = new Computer(cpu, ram);

      Console.WriteLine("Ihre WahL:");
      Console.WriteLine($"CPU:{computer.cpu.GetHersteller()}");
      Console.WriteLine($"Ram:{computer.ram}");
    }
  }
}