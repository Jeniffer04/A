using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWinFormsPt2
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            //new Exec02Saque().Show();
            //this.Hide();
            Exec02Saque f = new Exec02Saque();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            new Exec02Contas().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
