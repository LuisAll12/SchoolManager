using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
    public class Benutzer
    {
        public static int _id;
        public Benutzer(int id) { _id = id; LoadAllSchueler();  }
        public string Username = string.Empty;
        public string Nachname = string.Empty;
        public string Vorname = string.Empty;
        public DateTime Date = DateTime.MinValue;
        public string Stufe = string.Empty;
        public string Klasse = string.Empty;
        public int PLZ = int.MinValue;
        public string Ort = string.Empty;
        public string Strasse = string.Empty;
        public int Hausnum = int.MinValue;
        public string Tel = string.Empty;
        public string Password = string.Empty;
        public int Berechtigung = 0;
        public int FK_KLasse = 0;
        

        public string D23B = string.Empty;

        public void LoadAllSchueler()
        {
            //Herstellung einer Verbindung zwischen C# und Datenbank
            //Öffnet die Ergebnisse Schüler
            string query = "select * from Schueler where SchuelerID = @Value1";
            var Value1 = _id;

            using (OleDbConnection connection = new OleDbConnection(Program.connectionString))

            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Value1", Value1);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Username = reader.GetString(reader.GetOrdinal("Email"));
                    Password = reader.GetString(reader.GetOrdinal("Passwort"));
                    Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
                    Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
                    string Datestr = reader.GetString(reader.GetOrdinal("GebDatum"));
                    Date = Convert.ToDateTime(Datestr);
                    Stufe = reader.GetString(reader.GetOrdinal("Stufe"));
                    Klasse = reader.GetString(reader.GetOrdinal("Klasse"));
                    Tel = reader.GetString(reader.GetOrdinal("Tel"));
                    Ort = reader.GetString(reader.GetOrdinal("Ort"));
                    PLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                    Strasse = reader.GetString(reader.GetOrdinal("Strasse"));
                    Hausnum = reader.GetInt32(reader.GetOrdinal("Hausnummer"));
                    Berechtigung = reader.GetInt32(reader.GetOrdinal("Berechtigung"));
                }
                reader.Close();
                connection.Close();
            }


        }




    }
}
