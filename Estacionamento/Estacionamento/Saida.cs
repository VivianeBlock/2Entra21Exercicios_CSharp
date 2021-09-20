using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Saida : Form
    {
        public Saida()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Saida_Load(object sender, EventArgs e)
        {
            cbPlaca.Items.Clear();
            List<string> elements = Function.GenericUnitSelect("NumeroDaVagas", "Vagas");
            foreach (var item in elements)
            {
                cbPlaca.Items.Add(item);
            }
        }
    }
}
