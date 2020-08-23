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
    public partial class frmRelatorios : Form
    {
        DataSet_HeavenPieTableAdapters.VendasTableAdapter taVenda = new DataSet_HeavenPieTableAdapters.VendasTableAdapter();
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            dgvDetalhado.DataSource = taVenda.SelecionarTudo();
            DataSet ds = new DataSet();
            ds.Tables.Add(taVenda.SelecionarTudo());
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i < 0)
                {
                    i = 0;
                }
                int qtd = 0;
                string prod="";
                decimal valorTotal = 0, valor = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (valor == Convert.ToDecimal(ds.Tables[0].Rows[j].ItemArray[4].ToString()))
                    {
                         prod = ds.Tables[0].Rows[j].ItemArray[2].ToString();
                        qtd = qtd + Convert.ToInt16(ds.Tables[0].Rows[j].ItemArray[3].ToString());
                        valorTotal = valorTotal + Convert.ToDecimal(ds.Tables[0].Rows[j].ItemArray[5].ToString());
                        ds.Tables[0].Rows.RemoveAt(j);
                        j = j - 1;
                        i = i - 1;
                    }
                    

                }
                dgvGeral.Rows.Add(prod, qtd, valor, valorTotal);

                if (i < 0)
                {
                    i = 0;
                }
            }
            try
            {
                decimal total = 0;
                for (int k = 0; k < dgvGeral.Rows.Count; k++)
                {
                    total = total + Convert.ToDecimal(dgvGeral.Rows[k].Cells[3].Value);
                }
                dgvGeral.Rows.Add(null, null, "Total", total);

                total = 0;
                for (int k = 0; k < dgvDetalhado.Rows.Count; k++)
                {
                    total = total + Convert.ToDecimal(dgvDetalhado.Rows[k].Cells[5].ToString());
                }
                dgvDetalhado.Rows.Add(null, null, "Total", total);
            }
            catch { }
        }
        }
         
    }

