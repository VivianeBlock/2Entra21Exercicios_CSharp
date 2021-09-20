using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form03
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            Cb01.Items.Clear();
            List<string> elements = Function.GenericUnitSelect("Nome", "Dados");

            foreach(var item in elements)
            {
                Cb01.Items.Add(item);
            }


        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dgNome.Rows.Clear();

            string select = $"SELECT * from dbo.Dados WHERE Nome = '{Cb01.Text}'";
            SqlCommand comand = new SqlCommand(select, Function.Connection);
            Function.Connection.Open();
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                string[] elements = { dr[0].ToString(), dr[1].ToString(), FormatarCPF(dr[2].ToString()), dr[3].ToString() };
                dgNome.Rows.Add(elements);
            }
            dr.Close();
            Function.Connection.Close();
        }
        /// <summary>
        /// Formata o CPF para ficar na formatação certa
        /// </summary>
        /// <param name="Cpf"></param>
        /// <returns></returns>
        public string FormatarCPF(string Cpf)
        {
            return $@"{Convert.ToInt64(Cpf):000\.000\.000\-00}";
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
