using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    internal static class Program
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Database\\Schooldatabase.accdb;User Id=admin;Password=;";

        //static string connectionString = "Server=DESKTOP-HU6ST2I\\SQLEXPRESS;Database=Schoolmanager;Integrated Security=True;";
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Anmeldung());
        }
    }
}
