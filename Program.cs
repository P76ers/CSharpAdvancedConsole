using System;
using cSharpAdvancedConsole._04._17;

namespace cSharpAdvancedConsole
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int eingabe;
      do
      {
        Console.WriteLine("\nBitte wählen!");
        Console.WriteLine("[1]: Lesen");
        Console.WriteLine("[2]: Einfügen");
        Console.WriteLine("[3]: Aktualisieren");
        Console.WriteLine("[4]: Löschen");
        Console.WriteLine("[5]: Beenden");

        eingabe = Convert.ToInt32(Console.ReadLine());

        switch (eingabe)
        {
          case 1:
            DBProdukte.Lesen();
            break;
          case 2:
            EinfuegenMenu();
            break;
          case 3:
            // DBProdukte.Aktualisieren();
            AktualisierenMenu();
            break;
          case 4:
            DBProdukte.Loeschen();
            break;
        }
      } while (eingabe != 5);
    }

    public static void EinfuegenMenu()
    {
      Produkt produkt;

      Console.WriteLine("Artikelnummer:");
      int artikelNummer = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Produktnamen:");
      string name = Convert.ToString(Console.ReadLine());

      Console.WriteLine("Preis:");
      double preis = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Beschreibung:");
      string beschreibung = Console.ReadLine();

      Console.WriteLine("Anzahl:");
      int anzahl = Convert.ToInt32(Console.ReadLine());

      produkt = new Produkt(artikelNummer, name, preis, beschreibung, anzahl);

      DBProdukte.Einfuegen(produkt);
    }

    public static void AktualisierenMenu()
    {
      Produkt produkt = DBProdukte.GetProductById();
      int eingabe;

      do
      {
        Console.WriteLine("\n\nÄnderung?");
        Console.WriteLine("[1]: Artikelnummer");
        Console.WriteLine("[2]: Artikelname");
        Console.WriteLine("[3]: Preis");
        Console.WriteLine("[4]: Beschreibung");
        Console.WriteLine("[5]: Anzahl");
        Console.WriteLine("[6]: Datensatz ändern");
        eingabe = Convert.ToInt32(Console.ReadLine());

        switch (eingabe)
        {
          case 1:
            produkt.Artikelnummer = Convert.ToInt32(Console.ReadLine());
            break;
          case 2:
            produkt.Name = Convert.ToString(Console.ReadLine());
            break;
          case 3:
            produkt.Preis = Convert.ToDouble(Console.ReadLine());
            break;
          case 4:
            produkt.Beschreibung = Convert.ToString(Console.ReadLine());
            break;
          case 5:
            produkt.Anzahl = Convert.ToInt32(Console.ReadLine());
            break;
        }
      } while (eingabe != 6);

      DBProdukte.Aktualisieren(produkt);
    }
  }
}