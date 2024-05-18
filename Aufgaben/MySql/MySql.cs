using System;
using MySqlConnector;

namespace cSharpAdvancedConsole.Aufgaben.MySql
{
  public class MySql
  {
    private static string connectionString =
      "Server=127.0.0.1; Database=onlineshop;User=root;Password=;";

    private static MySqlConnection connection;

    public static void Verbinden()
    {
      try
      {
        connection = new MySqlConnection(connectionString);
        connection.Open();
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
    }

    public static void Lesen()
    {
      string sql;
      MySqlCommand command;
      MySqlDataReader reader;

      Verbinden();

      sql = "SELECT * FROM Kunden;";

      try
      {
        command = new MySqlCommand(sql, connection);
        reader = command.ExecuteReader();

        while (reader.Read())
        {
          Console.WriteLine($"id: {reader["id"]}");
          Console.WriteLine($"Vorname: {reader["vorname"]}");
          Console.WriteLine($"Nachname: {reader["nachname"]}");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
    }
  }
}