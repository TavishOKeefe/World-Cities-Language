// using System.Collections.Generic;
// using MySql.Data.MySqlClient;
//
// namespace Data.Models
// {
//   public class Country
//   {
//     private string _country;
//     private int _id;
//
//     public Country(string country, int id)
//     {
//       _country = country;
//       _id = id;
//     }
//
//     public static List<Country> GetAll()
//     {
//       List<Country> allCountrys = new List<Country>{};
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM country;";
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//
//       while(rdr.Read())
//       {
//         int Id = rdr.GetInt32(0);
//         string Country = rdr.GetString(1);
//
//         Country newCountry = new Country(Id, Country);
//         allCountrys.Add(newCountry);
//       }
//
//       conn.Close();
//
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//         return allCountrys;
//     }
//
//     public string GetCountry()
//     {
//       return _country;
//     }
//     public string SetCountry()
//     {
//       _country = country;
//     }
//
//   }
// }
