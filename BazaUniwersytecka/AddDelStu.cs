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

    public partial class AddDelStu : Form
    {
        static public string nrAlbumuAdd;
        static public string nrAlbumuDel;
        static public string Imie;
        static public string Nazwisko;
        static public string Wydzial;
        static public string Kierunek;
        public string Insert;
        public string Delete;


        public AddDelStu()
        {
            InitializeComponent();
        }


        //Metoda dodania Studenta
        private void Add_Click(object sender, EventArgs e)
        {

            nrAlbumuAdd = nrAlbBox.Text;
            Imie = ImBox.Text;
            Nazwisko = NazBox.Text;
            Wydzial = WydzBox.Text;
            Kierunek = KierBox.Text;

            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Insert into listastudentow(nrAlbumu, Imie, Nazwisko, Wydzial, Kierunek) values('{0}','{1}','{2}','{3}','{4}')", nrAlbumuAdd, Imie, Nazwisko, Wydzial, Kierunek);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            Insert = Convert.ToString(LoginWindow.command.ExecuteScalar());

        }
       

        private void Back_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            this.Close();
            this.Hide();

            A.ShowDialog();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
