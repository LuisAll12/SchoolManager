using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class LehrerInterface : Form
    {


        public LehrerInterface(Benutzer user)
        {
            InitializeComponent();
            Klasse1(user);



        }
        private void Klasse1(Benutzer user)
        {
            MainIchKlasse1.Text = user.FK_KLasse.ToString() + user.Klasse + " " + user.userId_Klasse1;
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
                    NavbarTextempty();
                }
            }
            else
            {
                //Vergrössert die Sidebar immer auf um 5 pixel bis 40 Ticks erreicht sind
                SideBarContainer.Width += 5;
                NavbarTextfill();
                if (SideBarContainer.Width == SideBarContainer.MaximumSize.Width)
                {

                    Sidebarexpand = true;
                    SidebarTimer.Stop();
                }
            }        
        }
        private void NavbarTextempty()
        {

            MainMenuNavIch.Text = string.Empty;
            MainMenuNavNews.Text = string.Empty;
            MainMenuNavAbsenz.Text = string.Empty;
            MainMenuNavNoten.Text = string.Empty;
            MainMenuNavStundenplan.Text = string.Empty;

        }
        private void NavbarTextfill()
        {
            MainMenuNavIch.Text =           "Meine Klassen";
            MainMenuNavNews.Text =          "News";
            MainMenuNavAbsenz.Text =        "Absenzen";
            MainMenuNavNoten.Text =         "Noten";
            MainMenuNavStundenplan.Text =   "Stundenplan";
        }


        private void IchBtn_click(object sender, EventArgs e)
        {

        }

        private void Newsbtn_click(object sender, EventArgs e)
        {

        }

        private void Klasse1_Click(object sender, EventArgs e)
        {


        }








        //(IchTable) Informationen


    }
}
