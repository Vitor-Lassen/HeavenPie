﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace HeavenPie
{
    class Limpar
    {
        public void limpar(Form f) // CRIAÇÃO DO MÉTODO, USANDO O PARÂMETRO f QUE REPRESENTA O FORM 
        {
            for (int i = 0 ; i < f.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if (f.Controls[i] is System.Windows.Forms.TextBox) // VERIFICA SE O CONTROLE É DO TIPO TextBox
                {
                    f.Controls[i].Text = "";
                }
                else if (f.Controls[i] is ComboBox)
                {
                    ((ComboBox)f.Controls[i]).SelectedIndex = -1;
                }
            }
        }
        public void limpar(Panel p) // CRIAÇÃO DO MÉTODO, USANDO O PARÂMETRO f QUE REPRESENTA O FORM 
        {
            for (int i = 0; i < p.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if ((p.Controls[i] is TextBox) || (p.Controls[i] is MaskedTextBox)) // VERIFICA SE O CONTROLE É DO TIPO TextBox
                {
                   p.Controls[i].Text = "";
                }
                
                else if (p.Controls[i] is ComboBox)
                {
                    ((ComboBox)p.Controls[i]).SelectedIndex = -1;
                }
            }
        }
    }
}
