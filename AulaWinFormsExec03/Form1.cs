using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWinFormsExec03
{
    public partial class Form1 : Form
    {
        List<string> nome = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome.Add(txtNome.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            foreach (var item in nome)
            {
                MessageBox.Show(item);
            }
        }
    }
}
