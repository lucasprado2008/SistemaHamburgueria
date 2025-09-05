namespace SistemaHamburgueria
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.txtCodPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorHamburguer = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkAlface = new System.Windows.Forms.CheckBox();
            this.chkTomate = new System.Windows.Forms.CheckBox();
            this.chkCebolaCaramelizada = new System.Windows.Forms.CheckBox();
            this.chkQueijoExtra = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.lblValorHamburguer = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.cmbTamanhoHamburguer = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaPedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbBurger = new System.Windows.Forms.PictureBox();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(351, 50);
            this.txtCodPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(92, 20);
            this.txtCodPedido.TabIndex = 33;
            // 
            // txtCodPesquisar
            // 
            this.txtCodPesquisar.Location = new System.Drawing.Point(88, 49);
            this.txtCodPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPesquisar.Name = "txtCodPesquisar";
            this.txtCodPesquisar.Size = new System.Drawing.Size(239, 20);
            this.txtCodPesquisar.TabIndex = 0;
            this.txtCodPesquisar.TextChanged += new System.EventHandler(this.txtCodPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(9, 50);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(85, 16);
            this.lblPesquisar.TabIndex = 31;
            this.lblPesquisar.Text = "Pesquisar: ";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(730, 247);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 53);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(557, 161);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 53);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(730, 161);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 53);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(194, 77);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.ReadOnly = true;
            this.txtValorOpcionais.Size = new System.Drawing.Size(85, 29);
            this.txtValorOpcionais.TabIndex = 27;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(326, 77);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.ReadOnly = true;
            this.txtValorPagar.Size = new System.Drawing.Size(85, 29);
            this.txtValorPagar.TabIndex = 26;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.Location = new System.Drawing.Point(323, 44);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(94, 15);
            this.lblValorPagar.TabIndex = 25;
            this.lblValorPagar.Text = "Valor a Pagar";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOpcionais.Location = new System.Drawing.Point(171, 44);
            this.lblValorOpcionais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(135, 15);
            this.lblValorOpcionais.TabIndex = 24;
            this.lblValorOpcionais.Text = "Valor dos Opcionais";
            // 
            // txtValorHamburguer
            // 
            this.txtValorHamburguer.Location = new System.Drawing.Point(39, 77);
            this.txtValorHamburguer.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorHamburguer.Name = "txtValorHamburguer";
            this.txtValorHamburguer.ReadOnly = true;
            this.txtValorHamburguer.Size = new System.Drawing.Size(85, 29);
            this.txtValorHamburguer.TabIndex = 23;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkAlface);
            this.grpOpcionais.Controls.Add(this.chkTomate);
            this.grpOpcionais.Controls.Add(this.chkCebolaCaramelizada);
            this.grpOpcionais.Controls.Add(this.chkQueijoExtra);
            this.grpOpcionais.Controls.Add(this.chkBacon);
            this.grpOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcionais.Location = new System.Drawing.Point(215, 88);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Size = new System.Drawing.Size(179, 138);
            this.grpOpcionais.TabIndex = 2;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "Escolha Opcionais";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkAlface
            // 
            this.chkAlface.AutoSize = true;
            this.chkAlface.Location = new System.Drawing.Point(4, 115);
            this.chkAlface.Margin = new System.Windows.Forms.Padding(2);
            this.chkAlface.Name = "chkAlface";
            this.chkAlface.Size = new System.Drawing.Size(70, 20);
            this.chkAlface.TabIndex = 7;
            this.chkAlface.Text = "Alface";
            this.chkAlface.UseVisualStyleBackColor = true;
            // 
            // chkTomate
            // 
            this.chkTomate.AutoSize = true;
            this.chkTomate.Location = new System.Drawing.Point(4, 94);
            this.chkTomate.Margin = new System.Windows.Forms.Padding(2);
            this.chkTomate.Name = "chkTomate";
            this.chkTomate.Size = new System.Drawing.Size(79, 20);
            this.chkTomate.TabIndex = 6;
            this.chkTomate.Text = "Tomate";
            this.chkTomate.UseVisualStyleBackColor = true;
            // 
            // chkCebolaCaramelizada
            // 
            this.chkCebolaCaramelizada.AutoSize = true;
            this.chkCebolaCaramelizada.Location = new System.Drawing.Point(4, 73);
            this.chkCebolaCaramelizada.Margin = new System.Windows.Forms.Padding(2);
            this.chkCebolaCaramelizada.Name = "chkCebolaCaramelizada";
            this.chkCebolaCaramelizada.Size = new System.Drawing.Size(176, 20);
            this.chkCebolaCaramelizada.TabIndex = 5;
            this.chkCebolaCaramelizada.Text = "Cebola Caramelizada";
            this.chkCebolaCaramelizada.UseVisualStyleBackColor = true;
            // 
            // chkQueijoExtra
            // 
            this.chkQueijoExtra.AutoSize = true;
            this.chkQueijoExtra.Location = new System.Drawing.Point(4, 52);
            this.chkQueijoExtra.Margin = new System.Windows.Forms.Padding(2);
            this.chkQueijoExtra.Name = "chkQueijoExtra";
            this.chkQueijoExtra.Size = new System.Drawing.Size(110, 20);
            this.chkQueijoExtra.TabIndex = 4;
            this.chkQueijoExtra.Text = "Queijo Extra";
            this.chkQueijoExtra.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(4, 31);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(70, 20);
            this.chkBacon.TabIndex = 3;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // lblValorHamburguer
            // 
            this.lblValorHamburguer.AutoSize = true;
            this.lblValorHamburguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHamburguer.Location = new System.Drawing.Point(13, 44);
            this.lblValorHamburguer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorHamburguer.Name = "lblValorHamburguer";
            this.lblValorHamburguer.Size = new System.Drawing.Size(144, 15);
            this.lblValorHamburguer.TabIndex = 21;
            this.lblValorHamburguer.Text = "Valor do Hambúrguer\r\n";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(531, 17);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(442, 122);
            this.dgvPedido.TabIndex = 20;
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // cmbTamanhoHamburguer
            // 
            this.cmbTamanhoHamburguer.FormattingEnabled = true;
            this.cmbTamanhoHamburguer.Location = new System.Drawing.Point(11, 88);
            this.cmbTamanhoHamburguer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTamanhoHamburguer.Name = "cmbTamanhoHamburguer";
            this.cmbTamanhoHamburguer.Size = new System.Drawing.Size(180, 21);
            this.cmbTamanhoHamburguer.TabIndex = 1;
            this.cmbTamanhoHamburguer.Text = "TAMANHO DO HAMBÚRGUER";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Gray;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(557, 247);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 53);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorHamburguer);
            this.groupBox1.Controls.Add(this.txtValorOpcionais);
            this.groupBox1.Controls.Add(this.txtValorPagar);
            this.groupBox1.Controls.Add(this.lblValorHamburguer);
            this.groupBox1.Controls.Add(this.lblValorOpcionais);
            this.groupBox1.Controls.Add(this.lblValorPagar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(13, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(430, 138);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 24);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Faça Seu Pedido";
            // 
            // dgvListaPedido
            // 
            this.dgvListaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedido.Location = new System.Drawing.Point(531, 328);
            this.dgvListaPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaPedido.Name = "dgvListaPedido";
            this.dgvListaPedido.RowHeadersWidth = 51;
            this.dgvListaPedido.RowTemplate.Height = 24;
            this.dgvListaPedido.Size = new System.Drawing.Size(353, 122);
            this.dgvListaPedido.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 465);
            this.label1.TabIndex = 36;
            // 
            // pcbBurger
            // 
            this.pcbBurger.Image = ((System.Drawing.Image)(resources.GetObject("pcbBurger.Image")));
            this.pcbBurger.Location = new System.Drawing.Point(29, 140);
            this.pcbBurger.Name = "pcbBurger";
            this.pcbBurger.Size = new System.Drawing.Size(141, 74);
            this.pcbBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbBurger.TabIndex = 37;
            this.pcbBurger.TabStop = false;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pcbBurger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaPedido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.txtCodPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbTamanhoHamburguer);
            this.Controls.Add(this.btnLimpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.TextBox txtCodPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorHamburguer;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkTomate;
        private System.Windows.Forms.CheckBox chkCebolaCaramelizada;
        private System.Windows.Forms.CheckBox chkQueijoExtra;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.Label lblValorHamburguer;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.ComboBox cmbTamanhoHamburguer;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkAlface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListaPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbBurger;
    }
}