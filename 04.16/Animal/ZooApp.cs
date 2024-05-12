using System.Collections.Generic;

namespace cSharpAdvancedConsole._04._16.Animal
{
  public class ZooApp
  {
    public static void Run()
    {
      Animal clownFish = new Aquatic("Nemo", 1, Gender.MALE);
      clownFish.Name = "Bla";
      clownFish.SetAge(2);

      Terrestrial simba = new Terrestrial("Simba", 1, Gender.MALE);
      Terrestrial nala = new Terrestrial("Nala", 2, Gender.FEMALE);

      Flying tweety = new Flying("Tweety", 3, Gender.MALE);

      List<Animal> animals = new List<Animal>();
      animals.Add(clownFish);
      animals.Add(simba);
      animals.Add(nala);
      animals.Add(tweety);

      foreach (var animal in animals)
      {
        animal.Move();
      }
    }
  }
}