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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentList_Click(object sender, EventArgs e)
        {
            LS listS = new LS();
            this.Close();
            listS.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginWindow LogWin = new LoginWindow();
            this.Hide();
            this.Close();
            LogWin.ShowDialog();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
