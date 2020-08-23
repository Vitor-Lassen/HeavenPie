using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeavenPie.View;


namespace HeavenPie
{
    public partial class frmLogin : Form
    {
        Limpar limpar = new Limpar();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "gabi") && (txtSenha.Text == "qwer"))
            {
                frmPrincipal principal = new frmPrincipal(this);
                this.Visible = false;
                limpar.limpar(this);
                txtLogin.Focus();
                principal.Show();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
