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
    public partial class ForStudents : Form
    {
        public ForStudents()
        {
            InitializeComponent();
        }

        //Metoda dla przycisku przejścia do Listy Studentów
        private void StudentList_Click(object sender, EventArgs e)
        {
            LS stli = new LS();
            this.Hide();
            this.Close();
            stli.ShowDialog();
            
        }

        //Metoda dla przycisku wylogowania się
        private void Logout_Click(object sender, EventArgs e)
        {
            LoginWindow LogWin = new LoginWindow();
            this.Hide();
            this.Close();
            LogWin.ShowDialog();
        }

        //Metoda dla Przycisku przejscia do Listy Pracownikow
        private void WorkersList_Click(object sender, EventArgs e)
        {
            WL lp = new WL();
            this.Hide();
            this.Close();
            lp.ShowDialog();
        }

        //Metoda zamykajaca aplikacje
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metoda do przejscia do Okna Wyszukanie Studetna(SearchStudent)
        private void StudentSearch_Click(object sender, EventArgs e)
        {
            SearchStudents SeSt = new SearchStudents();
            this.Close();
            this.Hide();
            SeSt.ShowDialog();
        }

        //Metoda dla przycisku przejscia do wyszukiwarki pracownikow
        private void WorkerSearch_Click(object sender, EventArgs e)
        {
            WorkersSearch WorkSearch = new WorkersSearch();
            this.Hide();
            this.Close();
            WorkSearch.ShowDialog();
        }
    }
}
