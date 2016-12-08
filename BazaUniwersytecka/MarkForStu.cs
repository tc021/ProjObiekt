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
    public partial class MarkForStu : Form
    {
        static public string nrAlbumu;
        static public string ocenaKoncowa;
        public string Ocena;
        public MarkForStu()
        {
            InitializeComponent();
        }


        //przycisk powrotu
        private void Back_Click(object sender, EventArgs e)
        {
            PracownikForm PFB = new PracownikForm();
            this.Close();
            this.Hide();
            PFB.ShowDialog();
        }

        //Metoda dla przycisku wystawiania oceny
        private void SetMarkB_Click(object sender, EventArgs e)
        {
            //Pobranie danych
            nrAlbumu = nrAlbumBox.Text;
            ocenaKoncowa = markBox.Text;
            if (ocenaKoncowa != "3" && ocenaKoncowa != "3.5" && ocenaKoncowa != "4" && ocenaKoncowa != "4.5" && ocenaKoncowa != "5")
            {
                MessageBox.Show("Ocent są w przedziale od 3 do 5");
            }
            else
            {
                try
                {
                    //Ustawienie Oceny
                    LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
                    LoginWindow.Upr = "Update listastudentow set OcenaKoncowa =" + ocenaKoncowa + " where nrAlbumu=" + nrAlbumu;
                    LoginWindow.connect.Open();
                    LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
                    Ocena = Convert.ToString(LoginWindow.command.ExecuteScalar());
                    MessageBox.Show("Ocena Wystawiona");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
            }
        }
    }
}
