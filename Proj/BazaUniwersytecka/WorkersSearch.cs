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
    public partial class WorkersSearch : Form
    {
        public WorkersSearch()
        {
            InitializeComponent();
        }
        //Metoda dla przycisku Szukaj
        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            //Pobieranie danych
            SearchStudents.Dane = SearchBox.Text;

            //Wyszukiwarka pracownikow
            
                LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
                LoginWindow.Upr = String.Format("Select * from listapracownikow where  Imie = '{0}' or idPracownika = '{0}' or Wydzial = '{0}' or Stanowisko = '{0}' or Przedmiot = '{0}' ", SearchStudents.Dane);
                LoginWindow.connect.Open();
                LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);

                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
           
        }

        //Metoda dla przycisku powrotu
        private void Back_Click(object sender, EventArgs e)
        {
            ForStudents ForSt = new ForStudents();
            this.Hide();
            this.Close();
            ForSt.ShowDialog();
        }

        //Metoda dla przycisku wyjscia  
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

