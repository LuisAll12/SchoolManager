using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
    public class Benutzer
    {
        public static int _id;
        public Benutzer(int id) { _id = id; LoadAll();  }
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
        

        public string D23B = string.Empty;

        public void LoadAll()
        {
            //Herstellung einer Verbindung zwischen C# und Datenbank
            string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
            //Öffnet die Ergebnisse Schüler
            string query = "select * from Schüler where SchülerID = @Value1";
            var Value1 = _id;

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value1", Value1);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Username = reader.GetString(reader.GetOrdinal("Email"));
                    Password = reader.GetString(reader.GetOrdinal("Passwort"));
                    Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
                    Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
                    Date = reader.GetDateTime(reader.GetOrdinal("GebDatum"));
                    Stufe = reader.GetString(reader.GetOrdinal("Stufe"));
                    Klasse = reader.GetString(reader.GetOrdinal("Klasse"));
                    Tel = reader.GetString(reader.GetOrdinal("Tel"));
                    Ort = reader.GetString(reader.GetOrdinal("Ort"));
                    PLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                    Strasse = reader.GetString(reader.GetOrdinal("Strasse"));
                    Hausnum = reader.GetInt32(reader.GetOrdinal("Hausnum"));
                    Berechtigung = reader.GetInt32(reader.GetOrdinal("Berechtigung"));

                }
                reader.Close();
                connection.Close();
            }
            
            private void LoadD23B()
            {
                //Herstellung einer Verbindung zwischen C# und Datenbank
                string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
                //Öffnet die Ergebnisse Schüler
                string query = "select * from Schüler where SchülerID = @Value1";
                var Value1 = _id;

                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Value1", Value1);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                     

                    }
                    reader.Close();
                    connection.Close();

                }
        }

       

    }
}
