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
using MySql.Data;


namespace BazaUniwersytecka
{
    public partial class LS : Form
    {

        
        public LS()
        {
            InitializeComponent();
        }

        
        private void MenuBack_Click(object sender, EventArgs e)
        {
            ForStudents StudWindow = new ForStudents();
            this.Hide();
            this.Close();

            StudWindow.ShowDialog();
        }

        private void LS_Load(object sender, EventArgs e)
        {
            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = "Select * from listastudnetow";
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(LoginWindow.command);
            
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
        }

       
    }
}
