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

namespace Forms01
{
    public partial class Form1 : Form
    {
        SqlConnection conect = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Cadastro";
            SqlCommand cmd = new SqlCommand(select, conect);
            conect.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show("\tNome: {0}", Name);
            }
            dr.Close();
            conect.Close();
        }
    }
}
