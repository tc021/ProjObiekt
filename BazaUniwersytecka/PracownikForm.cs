using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaUniwersytecka
{
    public partial class PracownikForm : Form
    {
        public PracownikForm()
        {
            InitializeComponent();
        }

        //Metoda dla przycsiku przejscia do Listy Studentow
        private void StudentList_Click(object sender, EventArgs e)
        {
            StudentLisForTeacher liStuForWorker = new StudentLisForTeacher();
            this.Close();
            this.Hide();
            liStuForWorker.ShowDialog();
        }

        private void PracownikForm_Load(object sender, EventArgs e)
        {

        }

        //Wyszukiwanie studenta dla pracownika
        private void StudentSearch_Click(object sender, EventArgs e)
        {
            SearchStuForWork SSFW = new SearchStuForWork();
            this.Hide();
            this.Close();
            SSFW.ShowDialog();
        }

        //Przycisk wylogowania się
        private void Logout_Click(object sender, EventArgs e)
        {
            LoginWindow LogOut = new LoginWindow();
            this.Hide();
            this.Close();
            LogOut.ShowDialog();
        }

        //Przycisk wyjścia
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metoda dla przycisku przejścia do wystawiania oceny
        private void SetStudentMark_Click(object sender, EventArgs e)
        {
            MarkForStu MFS = new MarkForStu();
            this.Close();
            this.Hide();
            MFS.ShowDialog();
        }

        //Metoda dla przycisku przejscia do listy pracowników
        private void WorkersList_Click(object sender, EventArgs e)
        {
            WorkList WLFW = new WorkList();
            this.Close();
            this.Hide();
            WLFW.ShowDialog();

        }
    }
}
