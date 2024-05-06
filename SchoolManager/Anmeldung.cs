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
    
    public partial class Anmeldung : Form
    {
        private static List<string> username = new List<string>();
        private static string password = string.Empty;
        private static string RealUsername = string.Empty;
        public int anmeldeID = 0;
        public Anmeldung()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void OnApplyClick(object sender, EventArgs e)
        {   
            bool Usernameisgiven = false;
            username = GetUsername();

            string ErrorMessage = string.Empty;
            username = GetUsername();
            for (int i = 0; i < username.Count; i++)
                if (AnmeldungEmailEing.Text == username[i]) { Usernameisgiven = true; RealUsername = username[i]; }
            password = GetPassword();
            if ((Usernameisgiven == false)) ErrorMessage += "Email falsch oder Passwort falsch\n";
            else if (!(AnmeldungPasswortEing.Text == password)) ErrorMessage += "Email falsch oder Passwort falsch\n";
            if (!string.IsNullOrEmpty(ErrorMessage)) MessageBox.Show($"{ErrorMessage}");
            else
            {   
                this.anmeldeID = GetID();
                this.Hide();
                var form2 = new SchoolmanagerMainMenu(anmeldeID);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private static List<string> GetUsername()
        {   
            List<string> Username = new List<string>();
            //Herstellung einer Verbindung zwischen C# und Datenbank
            string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
            //Öffnet die Ergebnisse Schüler
            string query = "select * from Schüler";
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Username.Add(reader.GetString(1));
                }reader.Close();
            }
            return Username;
        }

            private static string GetPassword()
        {
            string password = string.Empty;
            string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
            string query = "select * from Schüler where Email = @Value1";
            string Value = RealUsername;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value1", Value);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    password = reader.GetString(2);
                }
                reader.Close();
            }
            return password;
        }
        private static int GetID()
        {
            int id = 0;
            string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
            string query = "select * from Schüler where Email = @Value1";
            string Value = RealUsername;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value1", Value);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            return id;
        }


        private void Anmeldung_Load(object sender, EventArgs e)
        {

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Showpassword_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            AnmeldungPasswortEing.PasswordChar = Showpassword_checkbox.Checked ? '\0' : '*';
        }

        private void OnExitBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            AnmeldungEmailEing.Clear();
            AnmeldungPasswortEing.Clear();
        }
    }
}
