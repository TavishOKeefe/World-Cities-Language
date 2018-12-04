using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Data.Models
{
  public class City
  {
    private string _city;
    private int _population;

    public City(string city, int population)
    {
      _city = city;
      _population = population;
    }

    public static List<City> GetAll()
    {
      List<City> allCitys = new List<City>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT name, population FROM city;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        string city = rdr.GetString(0);
        int population = rdr.GetInt32(1);

        City newCity = new City(city, population);
        allCitys.Add(newCity);
      }

      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
        return allCitys;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string city)
    {
      _city = city;
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
