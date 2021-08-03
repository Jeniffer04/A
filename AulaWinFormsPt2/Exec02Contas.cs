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

namespace AulaWinFormsPt2
{
    public partial class Exec02Contas : Form
    {
        public Exec02Contas()
        {
            InitializeComponent();
        }

        private void listContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exec02Contas_Load(object sender, EventArgs e)
        {
            string select = "SELECT * from dbo.Conta";
            SqlCommand cmd = new SqlCommand(select, BDConnection.connection);
            BDConnection.connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string temp = $"{dr[0]}   {dr[1]}   {dr[2]:c}";
                listContas.Items.Add(temp);
            }
            dr.Close();
            BDConnection.connection.Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }
    }
}
