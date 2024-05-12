namespace cSharpAdvancedConsole._04._17
{
  public class Produkt
  {
    private int id;
    private int artikelnummer;
    private string name;
    private double preis;
    private string beschreibung;
    private int anzahl;

    public Produkt(int artikelnummer, string name, double preis, string beschreibung, int anzahl)
    {
      this.artikelnummer = artikelnummer;
      this.name = name;
      this.preis = preis;
      this.beschreibung = beschreibung;
      this.anzahl = anzahl;
    }

    public Produkt(int id, int artikelnummer, string name, double preis, string beschreibung, int anzahl)
    {
      this.id = id;
      this.artikelnummer = artikelnummer;
      this.name = name;
      this.preis = preis;
      this.beschreibung = beschreibung;
      this.anzahl = anzahl;
    }

    #region Properties

    public int Id
    {
      get => id;
      set => id = value;
    }

    public int Artikelnummer
    {
      get => artikelnummer;
      set => artikelnummer = value;
    }

    public string Name
    {
      get => name;
      set => name = value;
    }

    public double Preis
    {
      get => preis;
      set => preis = value;
    }

    public string Beschreibung
    {
      get => beschreibung;
      set => beschreibung = value;
    }

    public int Anzahl
    {
      get => anzahl;
      set => anzahl = value;
    }

    #endregion
  }
}