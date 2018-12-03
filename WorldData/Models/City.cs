using System.Collections.Generic;

namespace Data.Models
{
  public class WorldData
  {
    private string _city;

    public static List<WorldData> GetAll()
    {
      List<WorldData> allWorldDatas = new List<WorldData>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM city;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int Id = rdr.GetInt32(0);
        string City = rdr.GetString(1);

        WorldData newWorldData = new WorldData(Id, City);
        allWorldDatas.Add(newWorldData);
      }

      conn.Close();

      if (conn != null)
      {
        conn.Dispose();
      }
        return allItems;
    }

    public string GetCity()
    {
      return _city;
    }
    public string SetCity()
    {
      _city = city;
    }

  }
}
