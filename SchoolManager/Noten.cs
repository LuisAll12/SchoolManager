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
      Fach_tbx.Text = "Deutsch";
      Fach_tbx.ForeColor = Color.Gray;
      Note_tbx.Text = "0.0";
      Schueler_tbx.Text = "@sluz.ch";
    }

    private void OnApply_Click(object sender, EventArgs e)
    {
      string Fach = Fach_tbx.Text;
      double Note = Convert.ToDouble(Note_tbx.Text);
      string Email = Schueler_tbx.Text;
      string ErrorMessage = string.Empty;


      if (!Double.TryParse(Note_tbx.Text, out Note)) Note = double.NaN;
      if (Note < 1 || Note > 6) MessageBox.Show("Die Note muss zwischen 1 und 6 sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      else
      {

        if (String.IsNullOrEmpty(Fach_tbx.Text)) ErrorMessage += "Es muss ein Fach eingegeben werden\n";
        if (Double.IsNaN(Note)) ErrorMessage += "Es muss eine Note eingegeben werden\n";
        if (String.IsNullOrEmpty(Schueler_tbx.Text)) ErrorMessage += "Es muss eine Email eingegeben werden\n";
        if (!String.IsNullOrEmpty(ErrorMessage)) MessageBox.Show(ErrorMessage, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        else
        {
          int Id = GetID(Email);

          if (Fach == "Mathe") InsertintoFach(Note, Id, Fach);
          else if (Fach == "Deutsch") { Fach = "Deu"; InsertintoFach(Note, Id, Fach); }
          else if (Fach == "Informatik") { Fach = "Info"; InsertintoFach(Note, Id, Fach); }
          else if (Fach == "Französisch") { Fach = "Franz"; InsertintoFach(Note, Id, Fach); }

        }
      }
      


    }
    private void InsertintoFach(double Note, int Id, string Fach)
    {
      string queryFach = "update Noten set Anz"+ Fach + "Not = Anz"+ Fach + "Not + 1, Sum"+ Fach + "Not = Sum"+ Fach +"Not + @Value1 where ID = @Value2";
      var Value1 = Note;
      var Value2 = Id;
      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
      {
        using (OleDbCommand command = new OleDbCommand(queryFach, connection))
        {
          // Parameter für die Abfrage hinzufügen



          command.Parameters.AddWithValue("@Value1", Value1);
          command.Parameters.AddWithValue("@Value2", Value2);
          connection.Open();

          int rowsAffected = command.ExecuteNonQuery();


          if (rowsAffected <= 0)
          {
            MessageBox.Show("Fehler beim einfügen der Note!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else { MessageBox.Show("Note eingefügt", "Akzeptiert", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
        if (ID == 0) MessageBox.Show("Email nicht gefunden", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return ID;
        
      }
      
    }
    private void OnExit()
    { this.Close(); }





    private void OnX_Click(object sender, EventArgs e)
    {
      OnExit();
    }

    private void Schueler_tbx_TextChanged(object sender, EventArgs e)
    {

    }

    private void On_Fach_tbx_Click(object sender, EventArgs e)
    {
      Fach_tbx.Clear();
    }

    private void On_Note_tbx_Click(object sender, EventArgs e)
    {
      Note_tbx.Clear();
    }

    private void On_Email_tbx_Click(object sender, EventArgs e)
    {
      Schueler_tbx.Clear();
    }

    private void OnX_btn_Hover(object sender, EventArgs e)
    {
      X_Exit.BackColor = Color.Red;
    }

    private void OnX_btn_Leave(object sender, EventArgs e)
    {
      X_Exit.BackColor = Color.White;
    }
  }
}
