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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        //Przejcie do Listy stodentow dla admina
        private void StudentList_Click(object sender, EventArgs e)
        {
            ListSAdmin LSA = new ListSAdmin();
            this.Close();
            this.Hide();

            LSA.ShowDialog();

        }

        //Przejscie do Wyszukiwania Studentów dla admina
        private void StudSearch_Click(object sender, EventArgs e)
        {
            StSearchA SSA = new StSearchA();
            this.Close();
            this.Hide();

            SSA.ShowDialog();

        }

        //Przycisk do przejscia do okna dodawania/usuwania studenta
        private void AddDelStud_Click(object sender, EventArgs e)
        {
            AddDelStu ADS = new AddDelStu();
            this.Close();
            this.Hide();

            ADS.ShowDialog();
        }


        //Modyfikowanie tabeli studenci
        private void button5_Click(object sender, EventArgs e)
        {
            ModTabStu MTS = new ModTabStu();
            this.Close();
            this.Hide();

            MTS.ShowDialog();
        }
        

        //Lista Pracowników
        private void WorkersList_Click(object sender, EventArgs e)
        {
            LWfA lw = new LWfA();
            this.Close();
            this.Hide();
            lw.ShowDialog();
        }


        //Przycisk wyjscia
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Przycisk wylogowania
        private void Logout_Click(object sender, EventArgs e)
        {
            LoginWindow logout = new LoginWindow();
            this.Close();
            this.Hide();

            logout.ShowDialog();
        }


        //Przycisk przejscia do wyszukiwarki racowników
        private void SearchWorker_Click(object sender, EventArgs e)
        {
            SWfA SPdA = new SWfA();
            this.
                Close();
            this.
                Hide();

            SPdA.
                ShowDialog();

            
        }


        //Przycisk przejscia do Dodani usunieca Pracownika
        private void AddDelWorkier_Click(object sender, EventArgs e)
        {
            AddDellW adw = new AddDellW();
            this.Close();
            this.Hide();

            adw.ShowDialog();
        }

        private void ModTabWorkers_Click(object sender, EventArgs e)
        {
            ModTabW MTW = new ModTabW();
            this.Hide();
            this.Close();

            MTW.ShowDialog();
        }
    }
}
