namespace HeavenPie.View
{
    partial class frmRelatorios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDetalhado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvGeral = new System.Windows.Forms.DataGridView();
            this.txtProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtqtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDetalhado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalhado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDetalhado
            // 
            this.dgvDetalhado.AllowUserToAddRows = false;
            this.dgvDetalhado.AllowUserToDeleteRows = false;
            this.dgvDetalhado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalhado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalhado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalhado.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDetalhado.Location = new System.Drawing.Point(3, 3);
            this.dgvDetalhado.Name = "dgvDetalhado";
            this.dgvDetalhado.ReadOnly = true;
            this.dgvDetalhado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalhado.Size = new System.Drawing.Size(769, 424);
            this.dgvDetalhado.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvGeral);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geral";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvGeral
            // 
            this.dgvGeral.AllowUserToAddRows = false;
            this.dgvGeral.AllowUserToDeleteRows = false;
            this.dgvGeral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeral.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtProd,
            this.txtqtd,
            this.txtValorUnit,
            this.txtValorTotal});
            this.dgvGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeral.Location = new System.Drawing.Point(3, 3);
            this.dgvGeral.Name = "dgvGeral";
            this.dgvGeral.ReadOnly = true;
            this.dgvGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeral.Size = new System.Drawing.Size(769, 424);
            this.dgvGeral.TabIndex = 1;
            // 
            // txtProd
            // 
            this.txtProd.HeaderText = "Produto";
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            // 
            // txtqtd
            // 
            this.txtqtd.HeaderText = "Quantidade";
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.ReadOnly = true;
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.HeaderText = "Valor Unidade";
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.ReadOnly = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.HeaderText = "Valor Total";
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heaven Pie - Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDetalhado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtqtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValorTotal;
    }
}