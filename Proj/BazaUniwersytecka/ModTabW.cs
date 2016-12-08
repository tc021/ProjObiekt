using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BazaUniwersytecka
{
    public partial class ModTabW : Form
    {
        static public string AddTab;
        public string Dodanie;
        public ModTabW()
        {
            InitializeComponent();
        }


        //Dodanie tabeli
        private void AddTable_Click(object sender, EventArgs e)
        {
            AddTab = AddTabBox.Text;

            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Alter table listapracownikow add {0} varchar(20)", AddTab);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);
            dataAdapter.Fill(dataTable);
            MessageBox.Show("Tabela dodana");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Close();
            this.Hide();

            a.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
