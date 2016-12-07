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
    public partial class LS : Form
    {
        public LS()
        {
            InitializeComponent();
        }

        
        private void MenuBack_Click(object sender, EventArgs e)
        {
            StudentForm StudWindow = new StudentForm();
            this.Hide();
            this.Close();

            StudWindow.ShowDialog();
        }
    }
}
