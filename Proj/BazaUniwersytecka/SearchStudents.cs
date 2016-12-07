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

        //Metoda dla przycisku Szukaj
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Pobieranie danych
            Dane = SearchBox.Text;

            //Wyszukiwarka Studentow
            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Select * from listastudentow Where nrAlbumu = '{0}' or Imie = '{0}' or Nazwisko = '{0}' or Wydzial = '{0}' or Kierunek = '{0}' ", Dane);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;

        }




        //Metoda dla przycisku wyjścia
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Metoda dla przycisku powrotu do Okna Dla studenta
        private void Back_Click(object sender, EventArgs e)
        {
            ForStudents BackFS = new ForStudents();
            this.Close();
            this.Hide();
            BackFS.ShowDialog();
        }

    }
}
