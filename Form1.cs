using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class forApp : Form
    {
        Thread nt;
        public forApp()
        {
            InitializeComponent();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Gabriel" && txtSenha.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos");
            }

        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }
    }
}
