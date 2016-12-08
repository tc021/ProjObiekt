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
    public partial class WL : Form
    {
        public WL()
        {
            InitializeComponent();
        }

        //Metoda dla wyświetlenia tablicy listy pracownikow
        private void WL_Load(object sender, EventArgs e)
        {
            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = "Select * from listapracownikow";
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
            ForStudents ForStu = new ForStudents();
            this.Hide();
            this.Close();
            ForStu.ShowDialog();
        }
    }
}
