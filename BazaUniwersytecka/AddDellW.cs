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
    public partial class AddDellW : Form
    {
        public string IdWorker;
        public string Imie;
        public string Naziwsko;
        public string Wydzial;
        public string Stanowisko;
        public string Przedmiot;
        public string Insert;
        public string Del;
        
        public AddDellW()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            IdWorker = IdBox.Text;
            Imie = NameWbox.Text;
            Naziwsko = SubnWBox.Text;
            Wydzial = WWBox.Text;
            Stanowisko = SWBox.Text;
            Przedmiot = PWBox.Text;



            LoginWindow.connect = new MySqlConnection("server = localhost; userid = root; password = admin; database=bazauniwersytecka");
            LoginWindow.Upr = String.Format("Insert into listra pracownikow(IdPRacownika, Imie, Nazwisko, Wydzial, Stanowisko, Przedmiot) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5})", IdWorker, Imie, Naziwsko, Wydzial, Stanowisko, Przedmiot);
            LoginWindow.connect.Open();
            LoginWindow.command = new MySqlCommand(LoginWindow.Upr, LoginWindow.connect);
            Insert = Convert.ToString(LoginWindow.command.ExecuteScalar());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            this.Close();
            this.Hide();

            a.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
