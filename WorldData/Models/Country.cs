using System.Collections.Generic;

namespace Data.Models
{
  public class WorldData
  {
    private string _country;

    public static List<WorldData> GetAll()
    {
      List<WorldData> allWorldDatas = new List<WorldData>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int Id = rdr.GetInt32(0);
        string Country = rdr.GetString(1);

        WorldData newWorldData = new WorldData(Id, Country);
        allWorldDatas.Add(newWorldData);
      }

      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
        return allItems;
    }

    public string GetCountry()
    {
      return _country;
    }
    public string SetCountry()
    {
      _country = country;
    }

  }
}
