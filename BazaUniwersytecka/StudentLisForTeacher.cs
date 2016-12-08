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
    public partial class StudentLisForTeacher : Form
    {
        public StudentLisForTeacher()
        {
            InitializeComponent();
        }

        private void StudentLisForTeacher_Load(object sender, EventArgs e)
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

        //Metoda dla przycisku powrotu do Menu dla Studentów
        private void MenuBack_Click(object sender, EventArgs e)
        {
            PracownikForm WorkerWindow = new PracownikForm();
            this.Hide();
            this.Close();

            WorkerWindow.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
