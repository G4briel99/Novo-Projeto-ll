using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            String nome = TxtNome.Text;
            String senha = TxtSenha.Text;
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtSenha.Text = "";
        }
    }
}
