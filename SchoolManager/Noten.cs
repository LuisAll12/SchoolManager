using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManager
{
  public partial class Noten : Form
  {
    public Noten()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void OnClear_Click(object sender, EventArgs e)
    {
      Fach_tbx.Clear();
      Note_tbx.Text = "0,0";
      Schueler_tbx.Text = "@sluz.ch";
    }

    private void OnApply_Click(object sender, EventArgs e)
    {
      string Fach = Fach_tbx.Text;
      double Note = Convert.ToDouble(Note_tbx.Text);
      string Email = Schueler_tbx.Text;
      string ErrorMessage = string.Empty;


      if (!Double.TryParse(Note_tbx.Text, out Note)) Note = double.NaN;

      if (String.IsNullOrEmpty(Fach_tbx.Text)) ErrorMessage += "Es muss ein Fach eingegeben werden\n";
      if (Double.IsNaN(Note)) ErrorMessage += "Es muss eine Note eingegeben werden\n";
      if (String.IsNullOrEmpty(Schueler_tbx.Text)) ErrorMessage += "Es muss eine Email eingegeben werden\n";
      else
      {
        int Id = GetID(Email);

        if (Fach == "Mathe") {
          string queryFach = "update Noten set AnzMatheNot = AnzMatheNot + 1, SumMatheNot = SumMatheNot + @Value1 where ID = @Value2";
          var Value1 = Note;
          var Value2 = Id;
          using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
          {
            using (OleDbCommand command = new OleDbCommand(queryFach, connection))
            {
              // Parameter für die Abfrage hinzufügen


              connection.Open();
              command.Parameters.AddWithValue("@Value1", Value1);
              command.Parameters.AddWithValue("@Value2", Value2);


              int rowsAffected = command.ExecuteNonQuery();


              if (rowsAffected <= 0)
              {
                MessageBox.Show("Fehler beim einfügen der Note!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            }
          }
        }
      }



    }
    private int GetID(string Email)
    {
      //Herstellung einer Verbindung zwischen C# und Datenbank
      //Öffnet die Ergebnisse Schüler
      string query = "select SchuelerID from Schueler where Email = @Value1";
      var Value1 = Email;
      int ID = 0;

      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))

      {
        OleDbCommand command = new OleDbCommand(query, connection);
        command.Parameters.AddWithValue("@Value1", Value1);
        connection.Open();
        OleDbDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          ID = reader.GetInt32(0);
        }
        reader.Close();
        connection.Close();
        return ID;
      }
      
    }
    private void OnExit()
    { this.Close(); }





    private void OnX_Click(object sender, EventArgs e)
    {
      OnExit();
    }
  }
}
