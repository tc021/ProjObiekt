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
        static public String AddTab;
        static public string DelTab;
        public string Dodanie;
        public string Usun;



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
            MessageBox.Show("Tabela usunięta");
        }

    

        //Usuwanie tabeli
        private void DelTable_Click(object sender, EventArgs e)
        {
            DelTab = DelTable.Text;

            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Alter table listastudentow drop column"+DelTab);
            

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
    }
}
