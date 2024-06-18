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
          public Benutzer Id;

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
            Id = user;
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
    }

    private void On_Noten_Click(object sender, EventArgs e)
    {
      IchTableManager.Hide();
      StundenplanPB.Hide();
      Noten_table.Show();
    }

    private void OnClickInfo_best(object sender, EventArgs e)
    {

      string query = "Update Noten set Info_best = 1 where ID = @value1";
      var Value1 = Id;
      using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
      {
        try
        {
          connection.Open();
          using (OleDbCommand command = new OleDbCommand(query, connection))
          {
            command.Parameters.AddWithValue("@Value1", Value1);
            int rowsAffected = command.ExecuteNonQuery();
            MessageBox.Show("Note eingefügt", "Akzeptiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Konnte nicht ausgeführt werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }







    }
    //(IchTable) Informationen


  }
}
