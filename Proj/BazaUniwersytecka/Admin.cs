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

        //Modyfikowanie Studenta
        private void ModifyStudent_Click(object sender, EventArgs e)
        {
            ModStudent MS = new ModStudent();
            this.Close();
            this.Hide();

            MS.ShowDialog();
        }

        //Modyfikowanie tabeli studenci
        private void button5_Click(object sender, EventArgs e)
        {
            ModTabStu MTS = new ModTabStu();
            this.Close();
            this.Hide();

            MTS.ShowDialog();
        }
    }
}
