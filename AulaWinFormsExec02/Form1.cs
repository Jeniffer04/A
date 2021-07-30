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

namespace AulaWinFormsExec02
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaVesp;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // comandos
            if (!string.IsNullOrEmpty(txtLogin.Text))
            {
                string select = $"SELECT * from dbo.Usuario WHERE NomeDeusuario = '{txtLogin.Text}'";
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Senha"].ToString() == txtPassword.Text)
                    {
                        MessageBox.Show("Login Efetuado");
                    }
                    else
                    {
                        MessageBox.Show("Login fracassou miseravelmente");
                    }
                }
                else
                {
                    MessageBox.Show("Login nao encontrado em nossas tabelas");
                }
                dr.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Acerte seu proprio login, animal");
            }
        }
    }
}
