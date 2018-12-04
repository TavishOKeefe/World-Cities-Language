using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Data.Models
{
  public class Country
  {
    private string _country;
    private int _population;

    public Country(string country, int population)
    {
      _country = country;
      _population = population;
    }

    public static List<Country> GetAll()
    {
      List<Country> allCountrys = new List<Country>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        string country = rdr.GetString(1);
        int population = rdr.GetInt32(6);

        Country newCountry = new Country(country, population);
        allCountrys.Add(newCountry);
      }

      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
        return allCountrys;
    }

    public string GetCountry()
    {
      return _country;
    }
    public void SetCountry(string country)
    {
      _country = country;
    }
    public int GetPopulation()
    {
      return _population;
    }
    public void SetPopulation(int population)
    {
      _population = population;
    }

  }
}
