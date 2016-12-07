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
    public partial class SearchStudents : Form
    {
        public static string Dane;
        public SearchStudents()
        {
            InitializeComponent();
        }

        private void SearchStudents_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Pobieranie danych
            Dane = SearchBox.Text;

            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Select * from listastudentow where Imie='{0}' or Nazwisko = '{0}' or Wydzial = '{0}' or Kierunek = '{0}'",Dane);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ForStudents BackFS = new ForStudents();
            this.Close();
            this.Hide();
            BackFS.ShowDialog();
        }
    }
}
