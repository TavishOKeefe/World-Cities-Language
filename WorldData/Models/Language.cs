// using System.Collections.Generic;
// using MySql.Data.MySqlClient;
//
// namespace Data.Models
// {
//   public class Language
//   {
//     private string _language;
//     private int _id;
//
//     public Language(string language, int id)
//     {
//       _language = language;
//       _id = id;
//     }
//
//     public static List<Language> GetAll()
//     {
//       List<Language> allLanguages = new List<Language>{};
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM language;";
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//
//       while(rdr.Read())
//       {
//         int Id = rdr.GetInt32(0);
//         string Language = rdr.GetString(1);
//
//         Language newLanguage = new Language(id, Language);
//         allLanguages.Add(newLanguage);
//       }
//
//       conn.Close();
//
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//         return allLanguages;
//     }
//
//     public string GetLanguage()
//     {
//       return _language;
//     }
//     public string SetLanguage()
//     {
//       _language = Language;
//     }
//
//   }
// }
