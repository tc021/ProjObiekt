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
    public partial class ListSAdmin : Form
    {
        public ListSAdmin()
        {
            InitializeComponent();
        }

        //Przycisk cofnięcia
        private void MenuBack_Click(object sender, EventArgs e)
        {
            Admin AB = new Admin();
            this.Close();
            this.Hide();

            AB.ShowDialog();
        }


        //Przycisk Przejścia do DOdaj Usun studęta

   

        //Wyświetlenie Listy Studentów
        private void ListSAdmin_Load(object sender, EventArgs e)
        {
            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = "Select * from listastudentow";
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        private void StudentList_Click(object sender, EventArgs e)
        {
            AddDelStu ADS = new AddDelStu();
            this.Close();
            this.Hide();

            ADS.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
