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
    public partial class frmCaixa : Form
    {
        DataSet_HeavenPieTableAdapters.VendasTableAdapter taVenda = new DataSet_HeavenPieTableAdapters.VendasTableAdapter();
        int chave = 0;
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if ( chave == 0)
            {
                panelConfig.Visible = true;
                chave = 1;
            }
            else if (chave == 1)
            {
                panelConfig.Visible = false;
                chave = 0; 
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if ((txtProduto.Text == "")||(txtQtd.Text =="")||(txtConfigValor.Text=="")||(lblValorTotal.Text==""))
            {
                MessageBox.Show("Certifique-se digitou tudo corretamente!", "Algo errado não está certo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                taVenda.InsertVenda(
                     DateTime.Now.ToShortTimeString(),
                     txtProduto.Text,
                     Convert.ToInt16(txtQtd.Text),
                     Convert.ToDecimal(txtConfigValor.Text),
                     Convert.ToDecimal(lblValorTotal.Text)
                     );
                MessageBox.Show(txtQtd.Text +" pedaço(s) foi(foram) vendidos no valor de R$ "+lblValorTotal.Text, "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtd.Text = "1";
                txtValorRecebido.Text = "";
            }

        }

        private void txtConfigValor_TextChanged(object sender, EventArgs e)
        {
            lblValorUnit.Text = "R$ "+txtConfigValor.Text;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            lblProd.Text = txtProduto.Text;
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal preco = Convert.ToDecimal(txtConfigValor.Text);
                int qtd = Convert.ToInt16(txtQtd.Text);
                lblValorTotal.Text = Convert.ToString(preco * qtd);
            }
            catch { }
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            try{
            decimal total = Convert.ToDecimal(lblValorTotal.Text), recebido = Convert.ToDecimal(txtValorRecebido.Text);
            lblTroco.Text = Convert.ToString(recebido - total);
                 }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtQtd_TextChanged(sender, e);
            txtValorRecebido_TextChanged(sender, e);
        }

        private void txtConfigValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == ',') || ((Keys)e.KeyChar == Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValorRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == ',') || ((Keys)e.KeyChar == Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
