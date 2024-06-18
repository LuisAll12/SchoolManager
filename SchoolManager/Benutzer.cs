using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public class Benutzer
    {
        public static int _id;
        public Benutzer(int id) { _id = id; LoadAllSchueler(); LoadAllKlasse(); LoadKlasseStundenplan(); }
        //Variabeln Schüler
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
        //Variabeln Klasse
        public int KlasseID = int.MinValue;
        public string BezKlasse = string.Empty;
        // Stundenplan bild Variable
        public Image StundenplanBild;

        // Klassenliste als Liste mit Namen
        public List<int> userId_Klasse1 = new List<int>();
        // Noten
        public double SumMathe_Not = double.MinValue;
        public double AnzMathe_Not = double.MinValue;
        public double Deu_Not = double.MinValue;
        public double Info_Not = double.MinValue;
        public double Franz_Not = double.MinValue;


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
                    //string Datestr = reader.GetString(reader.GetOrdinal("GebDatum"));
                    //Date = Convert.ToDateTime(Datestr);
                    Date = reader.GetDateTime(reader.GetOrdinal("GebDatum"));
                    //Stufe = reader.GetString(reader.GetOrdinal("Stufe"));
                    Stufe = reader.GetInt32(reader.GetOrdinal("Stufe")).ToString();
                    Klasse = reader.GetString(reader.GetOrdinal("Klasse"));
                    //Tel = reader.GetString(reader.GetOrdinal("Tel"));
                    Tel = reader.GetInt32(reader.GetOrdinal("Tel")).ToString();
                    Ort = reader.GetString(reader.GetOrdinal("Ort"));
                    PLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                    Strasse = reader.GetString(reader.GetOrdinal("Strasse"));
                    Hausnum = reader.GetInt32(reader.GetOrdinal("Hausnummer"));
                    Berechtigung = reader.GetInt32(reader.GetOrdinal("Berechtigung"));
                    FK_KLasse = reader.GetInt32(reader.GetOrdinal("FK_Klasse"));
        }
                reader.Close();
                connection.Close();
            }


        }
        public void LoadAllKlasse()
        {
            //Herstellung einer Verbindung zwischen C# und Datenbank
            //Öffnet die Ergebnisse Schüler
            string query = "SELECT SchuelerID FROM Schueler WHERE FK_Klasse = @ForeignKey";
            var ForeignKey = FK_KLasse;

            using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ForeignKey", ForeignKey);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        userId_Klasse1.Add(reader.GetInt32(reader.GetOrdinal("SchuelerID"))); // Annahme: user_id ist ein INT
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            // Ausgabe der abgerufenen Benutzer-IDs


        }
    public void LoadKlasseStundenplan()
    {
      //Herstellung einer Verbindung zwischen C# und Datenbank
      //Öffnet die Ergebnisse Schüler
      string query = "select Stundenplan.FileData from Klasse where KlasseId = @Value1";
      var Value1 = FK_KLasse;

      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))

      {
        OleDbCommand command = new OleDbCommand(query, connection);
        command.Parameters.AddWithValue("@Value1", Value1);
        connection.Open();
        OleDbDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          Byte[] ImgBytes = (Byte[])reader[0];
          int HeaderLen = ImgBytes[0];
          Byte[] ImgArray = new Byte[ImgBytes.Length - HeaderLen];
          Array.Copy(ImgBytes, HeaderLen, ImgArray, 0, ImgBytes.Length - HeaderLen);
          MemoryStream MemStream = new MemoryStream(ImgArray);
          StundenplanBild = new Bitmap(Bitmap.FromStream(MemStream));
        }
        reader.Close();
        connection.Close();
      }


    }
    public void LoadAllNoten()
    {
      //Herstellung einer Verbindung zwischen C# und Datenbank
      //Öffnet die Ergebnisse Schüler
      string query = "select * from Noten where ID = @Value1";
      var Value1 = _id;

      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))

      {
        OleDbCommand command = new OleDbCommand(query, connection);
        command.Parameters.AddWithValue("@Value1", Value1);
        connection.Open();
        OleDbDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          SumMathe_Not = reader.GetDouble(reader.GetOrdinal("SumMatheNot"));
          AnzMathe_Not = reader.GetDouble(reader.GetOrdinal("AnzDeuNot"));
          Info_Not = reader.GetDouble(reader.GetOrdinal("InfoNot"));
          Franz_Not = reader.GetDouble(reader.GetOrdinal("FranzNot"));
        }
        reader.Close();
        connection.Close();
      }


    }



  }
}
