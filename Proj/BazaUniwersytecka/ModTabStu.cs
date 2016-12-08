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
    public partial class ModTabStu : Form
    {
        static public string AddTab;
        public string Dodanie;



        public ModTabStu()
        {
            InitializeComponent();
        }


        //Dodawanie tabeli
        private void AddTable_Click(object sender, EventArgs e)
        {

            AddTab = AddTabBox.Text;

            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Alter table listastudentow add {0} varchar(20)", AddTab);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);
            dataAdapter.Fill(dataTable);
            MessageBox.Show("Tabela dodana");
        }
        //Przycisk Cofnij
        private void Back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            this.Hide();
            this.Close();

            A.ShowDialog();

        }

        //Przucisk wyjdź
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            this.Close();

            a.ShowDialog();
        }
    }
}
