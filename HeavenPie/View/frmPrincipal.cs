using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeavenPie.View
{
    public partial class frmPrincipal : Form
    {
        int fechar = 0;
        frmLogin contexto = new frmLogin();
        public frmPrincipal(frmLogin contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fechar == 0)
            {
                Application.Exit();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tssHora.Text = DateTime.Now.ToShortTimeString();
            tssData.Text = DateTime.Now.ToLongDateString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contexto.Visible = true;
            fechar = 1;
            Close();
            
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa();
            caixa.ShowDialog();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.ShowDialog();
        }
    }
}
