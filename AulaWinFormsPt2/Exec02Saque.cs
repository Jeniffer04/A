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
    public partial class Exec02Saque : Form
    {
        public Exec02Saque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            int valor = RecebeSaldo();
            if (valor != -1)
            {
                MessageBox.Show($"Saldo : {valor:c}");
            }
        }

        private int RecebeSaldo()
        {
            int retorno = -1;
            string select = $"SELECT Saldo from dbo.Conta WHERE NumeroConta = '{txtConta.Text}'";
            SqlCommand cmd = new SqlCommand(select, BDConnection.connection);
            BDConnection.connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorno = Convert.ToInt32(dr[0]);
            }
            else
            {
                MessageBox.Show("Número da conta não encontrado");
            }
            dr.Close();
            BDConnection.connection.Close();

            return retorno;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            int saldo = RecebeSaldo();
            if (saldo != -1)
            {
                if (saldo >= Convert.ToInt32(txtQtd.Text))
                {
                    string update = $"UPDATE dbo.Conta Set Saldo -= {txtQtd.Text} WHERE NumeroConta = '{txtConta.Text}'";
                    SqlCommand cmd = new SqlCommand(update, BDConnection.connection);
                    BDConnection.connection.Open();
                    cmd.ExecuteNonQuery();
                    BDConnection.connection.Close();
                    txtConta.Clear();
                    txtQtd.Clear();
                }
                else
                {
                    MessageBox.Show($"Saldo atual: {saldo:c}\nSaldo insuficiente em sua conta bancária.\nPor que você não faz um depósito?");
                }
            }



        }
    }
}
