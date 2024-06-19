using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class SchuelerInterface : Form
    {
          public Benutzer Schüler;

        public SchuelerInterface(Benutzer user)
        {
            InitializeComponent();

            MainIchEmail.Text = user.Username;
            MainIchVorname.Text = user.Vorname;
            MainIchNachname.Text = user.Nachname;
            MainIchGebDate.Text = user.Date.ToShortDateString();
            MainIchStufe.Text = user.Stufe;
            MainIchKlasse.Text = user.Klasse;
            MainIchPLZ.Text = user.PLZ.ToString();
            MainIchOrt.Text = user.Ort;
            MainIchStrasse.Text = user.Strasse; 
            MainIchTel.Text = user.Tel;
            StundenplanPB.Hide();
            Noten_table.Hide();
            LoadStundenplan(user);
            LoadAllNote_Interface(user);
            Schüler = user;
        }


        private void LoadStundenplan(Benutzer user)
        {
          int FK_Klasse = user.FK_KLasse;
          Image Stundenplan = user.StundenplanBild;
          //Stundenplan = Convert.
          StundenplanPB.Image = Stundenplan;

        }


        bool Sidebarexpand;
        private static int _id = 0;



        private void OnmenuTransaktion(object sender, EventArgs e)
        {
     
            SidebarTimer.Start();
        }



        private void OnExit(object sender, EventArgs e)
        {
           this.Close();
        }
        private void SchoolmanagerMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (Sidebarexpand)
            {   
                //Verkleinert die Sidebar immer auf um 5 pixel bis 40 Ticks erreicht sind
                SideBarContainer.Width -= 5;
                if (SideBarContainer.Width == SideBarContainer.MinimumSize.Width) 
                {
                    Sidebarexpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                //Vergrössert die Sidebar immer auf um 5 pixel bis 40 Ticks erreicht sind
                SideBarContainer.Width += 5;
                if (SideBarContainer.Width == SideBarContainer.MaximumSize.Width)
                {
                    Sidebarexpand = true;
                    SidebarTimer.Stop();
                }
            }        
        }

        private void IchBtn_click(object sender, EventArgs e)
        {
            //Zeigt meine Informationen an
            IchTableManager.Show();
            StundenplanPB.Hide();
        }

        private void Newsbtn_click(object sender, EventArgs e)
        {
            //Entfernt alle Teilfenster
            IchTableManager.Hide();
        }

        private void MainMenuNavDaten_Click(object sender, EventArgs e)
        {
          IchTableManager.Hide();
          StundenplanPB.Show();
            //KLasse
        }

    private void IchTableManager_Paint(object sender, PaintEventArgs e)
    {

    }

    private void LoadAllNote_Interface(Benutzer user)
    {

      Note_Mathe_lbl.Text = user.Mathe_Not.ToString();
      Note_Deu_lbl.Text   = user.Deu_Not.ToString();
      Note_Franz_lbl.Text = user.Franz_Not.ToString();
      Note_Info_lbl.Text = user.Info_Not.ToString();

      Info_Chb.Checked = user.Info_Checked;
      Mathe_Chb.Checked = user.Mathe_Checked;
      Deu_Chb.Checked = user.Deu_Checked;
      Franz_Chb.Checked = user.Franz_Checked;
    }

    private void On_Noten_Click(object sender, EventArgs e)
    {
      IchTableManager.Hide();
      StundenplanPB.Hide();
      Noten_table.Show();
    }

    private void OnClickInfo_best(object sender, EventArgs e)
    {

      //string query = "Update Noten set Info_best = 1 where ID = @value1";
      int Value1 = Schüler.Ben_id;
      Schüler.Info_Checked = Info_Chb.Checked;
      int CheckStatus = Schüler.Info_Checked ? 1 : 0;
      string query = "Update Noten set Info_best = " + CheckStatus.ToString() + " where ID = @value1";
      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
      {
        try
        {
          connection.Open();
          using (OleDbCommand command = new OleDbCommand(query, connection))
          {
            command.Parameters.AddWithValue("@Value1", Value1);
            command.Parameters.AddWithValue("@CheckStatus", CheckStatus);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) MessageBox.Show("Note bestätigt", "Bestätigt", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Konnte nicht ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
      private void OnClickMathe_best(object sender, EventArgs e)
      {

        //string query = "Update Noten set Info_best = 1 where ID = @value1";
        int Value1 = Schüler.Ben_id;
        Schüler.Mathe_Checked = Mathe_Chb.Checked;
        int CheckStatus = Schüler.Mathe_Checked ? 1 : 0;
        string query = "Update Noten set Mathe_best = " + CheckStatus.ToString() + " where ID = @value1";

        using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
        {
          try
          {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
              command.Parameters.AddWithValue("@Value1", Value1);
              command.Parameters.AddWithValue("@CheckStatus", CheckStatus);
              int rowsAffected = command.ExecuteNonQuery();
              if (rowsAffected > 0) MessageBox.Show("Note bestätigt", "Bestätigt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show("Konnte nicht ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }


      }
    private void OnClickDeu_best(object sender, EventArgs e)
    {

      //string query = "Update Noten set Info_best = 1 where ID = @value1";
      int Value1 = Schüler.Ben_id;
      Schüler.Deu_Checked = Deu_Chb.Checked;
      int CheckStatus = Schüler.Deu_Checked ? 1 : 0;
      string query = "Update Noten set Deu_best = " + CheckStatus.ToString() + " where ID = @value1";

      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
      {
        try
        {
          connection.Open();
          using (OleDbCommand command = new OleDbCommand(query, connection))
          {
            command.Parameters.AddWithValue("@Value1", Value1);
            command.Parameters.AddWithValue("@CheckStatus", CheckStatus);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) MessageBox.Show("Note bestätigt", "Bestätigt", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Konnte nicht ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }


    }
    private void OnClickFranz_best(object sender, EventArgs e)
    {

      //string query = "Update Noten set Info_best = 1 where ID = @value1";
      int Value1 = Schüler.Ben_id;
      Schüler.Franz_Checked = Franz_Chb.Checked;
      int CheckStatus = Schüler.Franz_Checked ? 1 : 0;
      string query = "Update Noten set Franz_best = " + CheckStatus.ToString() + " where ID = @value1";

      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
      {
        try
        {
          connection.Open();
          using (OleDbCommand command = new OleDbCommand(query, connection))
          {
            command.Parameters.AddWithValue("@Value1", Value1);
            command.Parameters.AddWithValue("@CheckStatus", CheckStatus);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) MessageBox.Show("Note bestätigt", "Bestätigt", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Konnte nicht ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }


    }


    private void Noten_table_Paint(object sender, PaintEventArgs e)
    {

    }
    //(IchTable) Informationen


  }
}
