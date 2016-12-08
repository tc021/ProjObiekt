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
    public partial class LWfA : Form
    {
        public LWfA()
        {
            InitializeComponent();
        }


        //Wyswietlenie tabeli w gridzie
        private void LWfA_Load(object sender, EventArgs e)
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


        //Przycisk cofniecia
        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new BazaUniwersytecka.Admin();
            this.Close();
            this.Hide();

            a.ShowDialog();
        }


        //Przejscie do AddDellW
        private void DodUs_Click(object sender, EventArgs e)
        {
            AddDellW ADW = new AddDellW();
            this.Close();
            this.Hide();

            ADW.ShowDialog();
        }


        //Przejscie do ModTabW
        private void ModT_Click(object sender, EventArgs e)
        {
            ModTabW MTW = new ModTabW();
            this.Close();
            this.Hide();

            MTW.ShowDialog();
        }
    }
}
