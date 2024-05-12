using System;
using MySqlConnector;

namespace cSharpAdvancedConsole._04._17
{
  public class DBProdukte
  {
    // Connection
    private static string connectionString = "server=127.0.0.1;database=onlineshop;user=root;password= ;";
    private static MySqlConnection connection;

    public static void Verbinden()
    {
      try
      {
        connection = new MySqlConnection(connectionString);
        connection.Open();
        Console.WriteLine("ok");
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }

    public static void Lesen()
    {
      Verbinden();
      // sql-Befehl
      string sql = "SELECT * FROM produkte;";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      // Speichern der Rückgabe
      MySqlDataReader reader = command.ExecuteReader();

      // Schleife für alle Datensätze
      while (reader.Read())
      {
        Console.WriteLine($"ID \t\t{reader["id"]}");
        Console.WriteLine($"Artikelnummer \t{reader["Artikelnummer"]}");
        Console.WriteLine($"Name \t\t{reader["name"]}");
        Console.WriteLine($"Preis \t\t{reader["preis"]}");
        Console.WriteLine($"Beschreibung \t{reader["beschreibung"]}");
        Console.WriteLine($"Anzahl \t\t{reader["anzahl"]}");
      }
    }

    public static void Einfuegen(Produkt produkt)
    {
      Verbinden();


      string sql = "INSERT INTO produkte(artikelnummer, name, preis, beschreibung, anzahl) " +
                   "VALUES (@artikelnummer, @name, @preis, @beschreibung, @anzahl);";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      command.Parameters.AddWithValue("Artikelnummer", produkt.Artikelnummer);
      command.Parameters.AddWithValue("name", produkt.Name);
      command.Parameters.AddWithValue("preis", produkt.Preis);
      command.Parameters.AddWithValue("beschreibung", produkt.Beschreibung);
      command.Parameters.AddWithValue("anzahl", produkt.Anzahl);

      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        Console.WriteLine("Erfolg!");
      }
      else
      {
        Console.WriteLine("Fehler!");
      }

      connection.Dispose();
    }

    public static void AktualisierenAlt()
    {
      Verbinden();

      Produkt produkt;
      int eingabe;

      int id;
      int artikelNummer;
      string name;
      double preis;
      string beschreibung;
      int anzahl;

      Console.WriteLine("ID?:");
      id = Convert.ToInt32(Console.ReadLine());

      // sql-Befehl
      string sql = "SELECT * FROM produkte WHERE id = " + id.ToString() + ";";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      // Speichern der Rückgabe
      MySqlDataReader reader = command.ExecuteReader();

      reader.Read();


      artikelNummer = Convert.ToInt32(reader["Artikelnummer"]);
      name = Convert.ToString(reader["name"]);
      preis = Convert.ToDouble(reader["preis"]);
      beschreibung = Convert.ToString(reader["beschreibung"]);
      anzahl = Convert.ToInt32(reader["anzahl"]);


      Console.WriteLine($"Artikelnummer \t{artikelNummer}");
      Console.WriteLine($"Name \t\t{name}");
      Console.WriteLine($"Preis \t\t{preis}");
      Console.WriteLine($"Beschreibung \t{beschreibung}");
      Console.WriteLine($"Anzahl \t\t{anzahl}");

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
            artikelNummer = Convert.ToInt32(Console.ReadLine());
            break;
          case 2:
            name = Convert.ToString(Console.ReadLine());
            break;
          case 3:
            preis = Convert.ToDouble(Console.ReadLine());
            break;
          case 4:
            beschreibung = Convert.ToString(Console.ReadLine());

            break;
          case 5:
            anzahl = Convert.ToInt32(Console.ReadLine());
            break;
        }
      } while (eingabe != 6);

      connection.Dispose();
      Verbinden();

      produkt = new Produkt(artikelNummer, name, preis, beschreibung, anzahl);

      sql = "UPDATE `produkte` " +
            "SET artikelnummer=@artikelnummer,name=@name,preis=@preis,beschreibung=beschreibung,anzahl=anzahl " +
            "WHERE id= " + id.ToString() + ";";

      // Befehlausführung
      command = new MySqlCommand(sql, connection);


      command.Parameters.AddWithValue("Artikelnummer", produkt.Artikelnummer);
      command.Parameters.AddWithValue("name", produkt.Name);
      command.Parameters.AddWithValue("preis", produkt.Preis);
      command.Parameters.AddWithValue("beschreibung", produkt.Beschreibung);
      command.Parameters.AddWithValue("anzahl", produkt.Anzahl);

      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        Console.WriteLine("Erfolg!");
      }
      else
      {
        Console.WriteLine("Fehler!");
      }

      connection.Dispose();
    }


    public static void Loeschen()
    {
      Verbinden();

      string sql;
      int eingabe;

      Console.WriteLine("ID?");
      eingabe = Convert.ToInt32(Console.ReadLine());

      // sql Befehl
      sql = "DELETE FROM produkte WHERE ID = " + eingabe.ToString() + ";";

      // befehl wir an die verbindung gesendet
      MySqlCommand command = new MySqlCommand(sql, connection);

      // das commando wird ausgefürt.
      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        Console.WriteLine("Gelöscht");
      }
      else
      {
        Console.WriteLine("Fehler!");
      }

      connection.Dispose();

      Lesen();
    }

    public static Produkt GetProductById()
    {
      Verbinden();

      Produkt produkt;

      int id;
      int artikelNummer;
      string name;
      double preis;
      string beschreibung;
      int anzahl;

      Console.WriteLine("ID?:");
      id = Convert.ToInt32(Console.ReadLine());

      // sql-Befehl
      string sql = "SELECT * FROM produkte WHERE id = " + id.ToString() + ";";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      // Speichern der Rückgabe
      MySqlDataReader reader = command.ExecuteReader();

      reader.Read();

      artikelNummer = Convert.ToInt32(reader["Artikelnummer"]);
      name = Convert.ToString(reader["name"]);
      preis = Convert.ToDouble(reader["preis"]);
      beschreibung = Convert.ToString(reader["beschreibung"]);
      anzahl = Convert.ToInt32(reader["anzahl"]);

      Console.WriteLine($"Artikelnummer \t{artikelNummer}");
      Console.WriteLine($"Name \t\t{name}");
      Console.WriteLine($"Preis \t\t{preis}");
      Console.WriteLine($"Beschreibung \t{beschreibung}");
      Console.WriteLine($"Anzahl \t\t{anzahl}");

      produkt = new Produkt(id, artikelNummer, name, preis, beschreibung, anzahl);

      connection.Dispose();

      return produkt;
    }

    public static void Aktualisieren(Produkt produkt)
    {
      Verbinden();

      string sql;

      sql = "UPDATE `produkte` " +
            "SET artikelnummer=@artikelnummer,name=@name,preis=@preis,beschreibung=beschreibung,anzahl=anzahl " +
            "WHERE id= @id;";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      command.Parameters.AddWithValue("id", produkt.Id);
      command.Parameters.AddWithValue("Artikelnummer", produkt.Artikelnummer);
      command.Parameters.AddWithValue("name", produkt.Name);
      command.Parameters.AddWithValue("preis", produkt.Preis);
      command.Parameters.AddWithValue("beschreibung", produkt.Beschreibung);
      command.Parameters.AddWithValue("anzahl", produkt.Anzahl);

      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        Console.WriteLine("Erfolg!");
      }
      else
      {
        Console.WriteLine("Fehler!");
      }

      connection.Dispose();
    }
  }
}