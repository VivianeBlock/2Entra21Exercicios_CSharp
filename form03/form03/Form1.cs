using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            if (RBExec01.Checked)
            {
                new Exec01().Show();
                this.Hide();
            }
            else if (RBExec02.Checked)
            {
                MessageBox.Show("Falta fazer essa parte!");

            }

        }
    }
}
