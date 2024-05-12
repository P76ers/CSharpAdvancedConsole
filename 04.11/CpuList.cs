using System.Collections.Generic;

namespace cSharpAdvancedConsole._04._11
{
  public class CpuList
  {
    public static List<CPU> allCPUs = new List<CPU>();

    public static void addCPU()
    {
      CPU intel = new CPU();
      intel.SetHersteller("Intel");
      allCPUs.Add(intel);
      CPU amd = new CPU();
      amd.SetHersteller("AMD");
      allCPUs.Add(amd);
    }
  }
}