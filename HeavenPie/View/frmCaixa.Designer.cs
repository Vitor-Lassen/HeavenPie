namespace HeavenPie.View
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfigValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(282, 202);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(115, 44);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender ";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(98, 77);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(49, 20);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.Text = "1";
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Unitário:";
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Location = new System.Drawing.Point(95, 50);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(0, 13);
            this.lblValorUnit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(115, 117);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 13);
            this.lblValorTotal.TabIndex = 6;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(373, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(26, 23);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TabStop = false;
            this.btnConfig.Text = "...";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfig.Controls.Add(this.txtProduto);
            this.panelConfig.Controls.Add(this.label3);
            this.panelConfig.Controls.Add(this.txtConfigValor);
            this.panelConfig.Controls.Add(this.label6);
            this.panelConfig.Location = new System.Drawing.Point(197, 26);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(201, 72);
            this.panelConfig.TabIndex = 8;
            this.panelConfig.Visible = false;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(106, 39);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(84, 20);
            this.txtProduto.TabIndex = 6;
            this.txtProduto.TabStop = false;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // txtConfigValor
            // 
            this.txtConfigValor.Location = new System.Drawing.Point(106, 13);
            this.txtConfigValor.Name = "txtConfigValor";
            this.txtConfigValor.Size = new System.Drawing.Size(84, 20);
            this.txtConfigValor.TabIndex = 4;
            this.txtConfigValor.TabStop = false;
            this.txtConfigValor.TextChanged += new System.EventHandler(this.txtConfigValor_TextChanged);
            this.txtConfigValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfigValor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Configuração Valor";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTroco);
            this.panel1.Controls.Add(this.txtValorRecebido);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelConfig);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.txtQtd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblValorUnit);
            this.panel1.Location = new System.Drawing.Point(153, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 251);
            this.panel1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "R$";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(19, 11);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(0, 20);
            this.lblProd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Recebido:";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(114, 191);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(0, 13);
            this.lblTroco.TabIndex = 12;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(116, 151);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(63, 20);
            this.txtValorRecebido.TabIndex = 2;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            this.txtValorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorRecebido_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Troco:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 348);
            this.Controls.Add(this.panel1);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heaven Pie - Caixa ";
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.TextBox txtConfigValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}