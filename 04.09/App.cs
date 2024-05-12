namespace cSharpAdvancedConsole._04._09
{
  public class App
  {
    public static void Run()
    {
      int eingabe;
      Computer pc1 = new Computer();
      CPU cpu1 = new CPU(32);
      pc1.cpu = cpu1;
      pc1.ram = 16;
      pc1.graka = "Nvidia";
      pc1.hdd = "Seagate";

      CPU cpu2 = new CPU(32);
      Computer pc2 = new Computer("Intel", cpu2, "GTX", 32, "Westgate");

      Computer pc3 = new Computer("Intel", new CPU(32), "GTX", 32, "Westgate");
    }
  }
}