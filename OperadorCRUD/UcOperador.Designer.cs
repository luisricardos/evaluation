namespace OperadorCRUD
{
    partial class UcOperador
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodPraca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rdbSelecionar = new System.Windows.Forms.RadioButton();
            this.rdbInserir = new System.Windows.Forms.RadioButton();
            this.rdbAtualizar = new System.Windows.Forms.RadioButton();
            this.rdbExcluir = new System.Windows.Forms.RadioButton();
            this.txtCodOperador = new System.Windows.Forms.TextBox();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtPraca = new System.Windows.Forms.TextBox();
            this.gvOperadores = new System.Windows.Forms.DataGridView();
            this.gvCodOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvNmOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPercentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPraca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCodPraca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Operador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Operador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentual(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite:";
            // 
            // lblCodPraca
            // 
            this.lblCodPraca.AutoSize = true;
            this.lblCodPraca.Location = new System.Drawing.Point(36, 400);
            this.lblCodPraca.Name = "lblCodPraca";
            this.lblCodPraca.Size = new System.Drawing.Size(54, 20);
            this.lblCodPraca.TabIndex = 4;
            this.lblCodPraca.Text = "Praça:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(284, 451);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(201, 56);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // rdbSelecionar
            // 
            this.rdbSelecionar.AutoSize = true;
            this.rdbSelecionar.Location = new System.Drawing.Point(163, 42);
            this.rdbSelecionar.Name = "rdbSelecionar";
            this.rdbSelecionar.Size = new System.Drawing.Size(109, 24);
            this.rdbSelecionar.TabIndex = 7;
            this.rdbSelecionar.TabStop = true;
            this.rdbSelecionar.Text = "Selecionar";
            this.rdbSelecionar.UseVisualStyleBackColor = true;
            this.rdbSelecionar.CheckedChanged += new System.EventHandler(this.RdbSelecionar_CheckedChanged);
            // 
            // rdbInserir
            // 
            this.rdbInserir.AutoSize = true;
            this.rdbInserir.Location = new System.Drawing.Point(325, 42);
            this.rdbInserir.Name = "rdbInserir";
            this.rdbInserir.Size = new System.Drawing.Size(78, 24);
            this.rdbInserir.TabIndex = 8;
            this.rdbInserir.TabStop = true;
            this.rdbInserir.Text = "Inserir";
            this.rdbInserir.UseVisualStyleBackColor = true;
            this.rdbInserir.CheckedChanged += new System.EventHandler(this.RdbInserir_CheckedChanged);
            // 
            // rdbAtualizar
            // 
            this.rdbAtualizar.AutoSize = true;
            this.rdbAtualizar.Location = new System.Drawing.Point(469, 42);
            this.rdbAtualizar.Name = "rdbAtualizar";
            this.rdbAtualizar.Size = new System.Drawing.Size(96, 24);
            this.rdbAtualizar.TabIndex = 9;
            this.rdbAtualizar.TabStop = true;
            this.rdbAtualizar.Text = "Atualizar";
            this.rdbAtualizar.UseVisualStyleBackColor = true;
            this.rdbAtualizar.CheckedChanged += new System.EventHandler(this.RdbAtualizar_CheckedChanged);
            // 
            // rdbExcluir
            // 
            this.rdbExcluir.AutoSize = true;
            this.rdbExcluir.Location = new System.Drawing.Point(637, 42);
            this.rdbExcluir.Name = "rdbExcluir";
            this.rdbExcluir.Size = new System.Drawing.Size(80, 24);
            this.rdbExcluir.TabIndex = 10;
            this.rdbExcluir.TabStop = true;
            this.rdbExcluir.Text = "Excluir";
            this.rdbExcluir.UseVisualStyleBackColor = true;
            this.rdbExcluir.CheckedChanged += new System.EventHandler(this.RdbExcluir_CheckedChanged);
            // 
            // txtCodOperador
            // 
            this.txtCodOperador.Enabled = false;
            this.txtCodOperador.Location = new System.Drawing.Point(172, 90);
            this.txtCodOperador.Name = "txtCodOperador";
            this.txtCodOperador.Size = new System.Drawing.Size(100, 26);
            this.txtCodOperador.TabIndex = 11;
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Enabled = false;
            this.txtNomeOperador.Location = new System.Drawing.Point(172, 154);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(492, 26);
            this.txtNomeOperador.TabIndex = 12;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Enabled = false;
            this.txtPercentual.Location = new System.Drawing.Point(172, 218);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(100, 26);
            this.txtPercentual.TabIndex = 13;
            this.txtPercentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPercentual_KeyPress);
            // 
            // txtLimite
            // 
            this.txtLimite.Enabled = false;
            this.txtLimite.Location = new System.Drawing.Point(172, 277);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 26);
            this.txtLimite.TabIndex = 14;
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLimite_KeyPress);
            // 
            // txtPraca
            // 
            this.txtPraca.Enabled = false;
            this.txtPraca.Location = new System.Drawing.Point(172, 400);
            this.txtPraca.Name = "txtPraca";
            this.txtPraca.Size = new System.Drawing.Size(492, 26);
            this.txtPraca.TabIndex = 16;
            // 
            // gvOperadores
            // 
            this.gvOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOperadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvCodOperador,
            this.gvNmOperador,
            this.gvPercentual,
            this.gvLimite,
            this.gvStatus,
            this.gvPraca});
            this.gvOperadores.Location = new System.Drawing.Point(12, 535);
            this.gvOperadores.Name = "gvOperadores";
            this.gvOperadores.RowHeadersWidth = 62;
            this.gvOperadores.RowTemplate.Height = 28;
            this.gvOperadores.Size = new System.Drawing.Size(770, 150);
            this.gvOperadores.TabIndex = 17;
            this.gvOperadores.Visible = false;
            // 
            // gvCodOperador
            // 
            this.gvCodOperador.Frozen = true;
            this.gvCodOperador.HeaderText = "Cod Operador";
            this.gvCodOperador.MinimumWidth = 8;
            this.gvCodOperador.Name = "gvCodOperador";
            this.gvCodOperador.Width = 150;
            // 
            // gvNmOperador
            // 
            this.gvNmOperador.HeaderText = "Nome Operador";
            this.gvNmOperador.MinimumWidth = 8;
            this.gvNmOperador.Name = "gvNmOperador";
            this.gvNmOperador.ReadOnly = true;
            this.gvNmOperador.Width = 150;
            // 
            // gvPercentual
            // 
            this.gvPercentual.HeaderText = "Percentual";
            this.gvPercentual.MinimumWidth = 8;
            this.gvPercentual.Name = "gvPercentual";
            this.gvPercentual.ReadOnly = true;
            this.gvPercentual.Width = 150;
            // 
            // gvLimite
            // 
            this.gvLimite.HeaderText = "Limite";
            this.gvLimite.MinimumWidth = 8;
            this.gvLimite.Name = "gvLimite";
            this.gvLimite.ReadOnly = true;
            this.gvLimite.Width = 150;
            // 
            // gvStatus
            // 
            this.gvStatus.HeaderText = "Status";
            this.gvStatus.MinimumWidth = 8;
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            this.gvStatus.Width = 150;
            // 
            // gvPraca
            // 
            this.gvPraca.HeaderText = "Descrição Praça";
            this.gvPraca.MinimumWidth = 8;
            this.gvPraca.Name = "gvPraca";
            this.gvPraca.ReadOnly = true;
            this.gvPraca.Width = 150;
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cboStatus.Location = new System.Drawing.Point(172, 339);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 28);
            this.cboStatus.TabIndex = 18;
            // 
            // txtCodPraca
            // 
            this.txtCodPraca.Enabled = false;
            this.txtCodPraca.Location = new System.Drawing.Point(172, 400);
            this.txtCodPraca.Name = "txtCodPraca";
            this.txtCodPraca.Size = new System.Drawing.Size(100, 26);
            this.txtCodPraca.TabIndex = 19;
            this.txtCodPraca.Visible = false;
            // 
            // ucCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCodPraca);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.gvOperadores);
            this.Controls.Add(this.txtPraca);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.txtCodOperador);
            this.Controls.Add(this.rdbExcluir);
            this.Controls.Add(this.rdbAtualizar);
            this.Controls.Add(this.rdbInserir);
            this.Controls.Add(this.rdbSelecionar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCodPraca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCRUD";
            this.Size = new System.Drawing.Size(800, 720);
            ((System.ComponentModel.ISupportInitialize)(this.gvOperadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rdbSelecionar;
        private System.Windows.Forms.RadioButton rdbInserir;
        private System.Windows.Forms.RadioButton rdbAtualizar;
        private System.Windows.Forms.RadioButton rdbExcluir;
        private System.Windows.Forms.TextBox txtCodOperador;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtPraca;
        private System.Windows.Forms.DataGridView gvOperadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCodOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvNmOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPercentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPraca;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCodPraca;
        private System.Windows.Forms.Label lblCodPraca;
    }
}
