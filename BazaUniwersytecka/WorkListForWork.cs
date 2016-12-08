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
    public partial class WorkList : Form
    {
        public WorkList()
        {
            InitializeComponent();
        }

        //Wyświetlenie Listy pracowników
        private void WorkListForWork_Load(object sender, EventArgs e)
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

        //Przycisk powrotu
        private void Back_Click(object sender, EventArgs e)
        {
            PracownikForm PF = new PracownikForm();
            this.Close();
            this.Hide();

            PF.ShowDialog();

        }
    }
}
