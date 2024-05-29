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
    
    public partial class Anmeldung : Form
    {
        private static List<string> username = new List<string>();
        private static string password = string.Empty;
        private static string RealUsername = string.Empty;
        public int anmeldeID = 0;
        public Benutzer obj = null;
        public Anmeldung()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void OnApplyClick(object sender, EventArgs e)
        {  
            string ErrorMessage = string.Empty;
            string username = AnmeldungEmailEing.Text;
            string password = AnmeldungPasswortEing.Text;
            int userid = GetID(username);

            if (userid > 0)
            {
                Benutzer user = new Benutzer(userid);
                if (user.Password == password)
                {
                    if (user.Berechtigung == 1) 
                    { 
                        this.Hide();
                        var form2 = new SchuelerInterface(user);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else if (user.Berechtigung == 2)
                    {
                        this.Hide();
                        var form3 = new LehrerInterface(user);
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
                    }
                }
                else ErrorMessage += "Email oder Passwort falsch\n";
            } 
            else ErrorMessage += "Email oder Passwort falsch\n";
            if (!string.IsNullOrEmpty(ErrorMessage)) MessageBox.Show($"{ErrorMessage}");



            //bool Usernameisgiven = false;

            //string ErrorMessage = string.Empty;
            //username = GetUsername();
            //for (int i = 0; i < username.Count; i++)
            //    if (AnmeldungEmailEing.Text == username[i]) { Usernameisgiven = true; RealUsername = username[i]; }
            //password = GetPassword();
            //if ((Usernameisgiven == false)) ErrorMessage += "Email falsch oder Passwort falsch\n";
            //else if (!(AnmeldungPasswortEing.Text == password)) ErrorMessage += "Email falsch oder Passwort falsch\n";
            //if (!string.IsNullOrEmpty(ErrorMessage)) MessageBox.Show($"{ErrorMessage}");
            //else
            //{
            //    this.anmeldeID = GetID();
            //    this.Hide();
            //    var form2 = new SchoolmanagerMainMenu(anmeldeID, this);
            //    obj = new Inputs(anmeldeID);
            //    form2.Closed += (s, args) => this.Close();
            //    form2.Show();
            //}
        }

 


        private static int GetID(string username)
        {
            int id = 0;
            string query = "select * from Schueler where Email = @Value1";
            string Value = username;
            using (OleDbConnection connection = new OleDbConnection(Program.connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Value1", Value);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
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
