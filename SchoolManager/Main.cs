using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class SchoolmanagerMainMenu : Form
    {
        public SchoolmanagerMainMenu(int id)
        {
            InitializeComponent();
            _id = id;
            Input(_id);
        }



        //Vorname
        private static string GetVorname()
        {
            string Vorname = string.Empty;      //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Vorname = reader.GetString(3);
                }
                reader.Close();
            }
            return Vorname;
        }
        private static string GetNachname()
        {
            string Nachname = string.Empty;      //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Nachname = reader.GetString(4);
                }
                reader.Close();
            }
            return Nachname;
        }
        private static string GetGebDate()
        {
            DateTime Date = DateTime.MinValue;   //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Date = reader.GetDateTime(5);
                }
                reader.Close();
            }
            string zeitString = Date.ToString("dd.MM.yyyy");
            return zeitString;
        }
        private static string GetStufe()
        {
            string Stufe = string.Empty;   //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Stufe = reader.GetString(6);
                }
                reader.Close();
            }
            return Stufe;
        }
        private static string GetKlasse()
        {
            string Klasse = string.Empty;   //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Klasse = reader.GetString(7);
                }
                reader.Close();
            }
                
            return Klasse;
        }
        private static string GetPLZ()
        {
            int PLZ = int.MinValue;   //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    PLZ = reader.GetInt32(9);
                }
                reader.Close();
            }
            string Plz = PLZ.ToString();
            return Plz;
        }
        private static string GetOrt()
        {
            string Ort = string.Empty;   //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Ort = reader.GetString(10);
                }
                reader.Close();
            }

            return Ort;
        }

        private static string GetUsername()
        {
            string Username = string.Empty;      //Herstellung einer Verbindung zwischen C# und Datenbank
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
                    Username = reader.GetString(1);
                }
                reader.Close();
            }
            return Username;
        }


        bool Sidebarexpand;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private static int _id = 0;





        private void OnmenuTransaktion(object sender, EventArgs e)
        {
     
            SidebarTimer.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnExit(object sender, EventArgs e)
        {
           this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

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
        }

        private void Newsbtn_click(object sender, EventArgs e)
        {
            //Entfernt alle Teilfenster
            IchTableManager.Hide();
        }






        //(IchTable) Informationen
        public void Input(int id)
        {
            string username;
            int _id = id;
            username = GetUsername();
            MainIchEmail.Text = GetUsername();
            MainIchVorname.Text = GetVorname();
            MainIchNachname.Text = GetNachname();
            MainIchGebDate.Text = GetGebDate();
            MainIchStufe.Text = GetStufe();
            MainIchKlasse.Text = GetKlasse();
            MainIchPLZ.Text = GetPLZ();
            MainIchOrt.Text = GetOrt();
        }

    }
}
