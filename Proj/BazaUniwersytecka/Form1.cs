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
    public partial class LoginWindow : Form
    {
        static public string login;
        static public string passwd;
        public MySqlConnection connect;
        public string Uprawnienie;



        public LoginWindow()
        {
            InitializeComponent();
        }




        private void Logowanie_Click(object sender, EventArgs e)
        {
            //Pobieranie danych logowania
            login = LoginBox.Text;
            passwd = PassBox.Text;

            //Laczenie z baza danych i sprawdzanie poprawnosci loginu i hasła
            try
            {
                connect = new MySqlConnection("server=localhost;user id=" + login + "; password=" + passwd + ";database=bazauniwersytecka");
                connect.Open();
           
            //Sprawdzanie uprawnien
            MySqlCommand command;
            string Upr = String.Format("Select Uprawnienie from uzytkownicy Where uzytkownicy.Login = '{0}'", login);
            command = new MySqlCommand(Upr, connect);
            Uprawnienie = Convert.ToString(command.ExecuteScalar());
            }
            catch (MySqlException wyjatek)
            {
                MessageBox.Show("Zle haslo albo login");
            }

            if (Uprawnienie == "Std")
            {
                PracownikForm st = new PracownikForm();
                this.Hide(); 
                st.ShowDialog();
            }
            
            else if(Uprawnienie == "Pr")
            {
                PracownikForm pr = new PracownikForm();
                this.Hide();
                pr.ShowDialog();
            }
            else if(Uprawnienie == "Admin")
            {
                Admin Ad = new Admin();
                this.Hide();
                Ad.ShowDialog();
            }
            
        }

        //Metoda dla przycisku "Wyjście"
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
