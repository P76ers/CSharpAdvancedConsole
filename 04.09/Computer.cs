namespace cSharpAdvancedConsole._04._09
{
  public class Computer
  {
    public string hersteller;
    public CPU cpu;
    public string graka;
    public string hdd;
    public int ram;

    public Computer(string hersteller, CPU cpu, string graka, int ram, string hdd)
    {
      this.hersteller = hersteller;
      this.cpu = cpu;
      this.graka = graka;
      this.ram = ram;
      this.hdd = hdd;
    }

    public Computer()
    {
    }
  }
}