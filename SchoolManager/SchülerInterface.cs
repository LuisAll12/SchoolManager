using System;
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
            LoadStundenplan(user);

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








    //(IchTable) Informationen


  }
}
