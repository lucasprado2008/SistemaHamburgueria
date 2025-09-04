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
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkTomate = new System.Windows.Forms.CheckBox();
            this.chkCebolaCaramelizada = new System.Windows.Forms.CheckBox();
            this.chkQueijoExtra = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.lblValorHamburguer = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.cmbTamanhoHamburguer = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.chkAlface = new System.Windows.Forms.CheckBox();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(339, 6);
            this.txtCodPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(92, 20);
            this.txtCodPedido.TabIndex = 33;
            // 
            // txtCodPesquisar
            // 
            this.txtCodPesquisar.Location = new System.Drawing.Point(84, 6);
            this.txtCodPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPesquisar.Name = "txtCodPesquisar";
            this.txtCodPesquisar.Size = new System.Drawing.Size(239, 20);
            this.txtCodPesquisar.TabIndex = 32;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(11, 9);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblPesquisar.TabIndex = 31;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(801, 367);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 32);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(703, 368);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(72, 32);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(599, 368);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(72, 32);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(667, 95);
            this.txtValorOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(85, 20);
            this.txtValorOpcionais.TabIndex = 27;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(794, 95);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(85, 20);
            this.txtValorPagar.TabIndex = 26;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(791, 69);
            this.lblValorPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 25;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(645, 69);
            this.lblValorOpcionais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 24;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(529, 95);
            this.txtValorPizza.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(85, 20);
            this.txtValorPizza.TabIndex = 23;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkAlface);
            this.grpOpcionais.Controls.Add(this.chkTomate);
            this.grpOpcionais.Controls.Add(this.chkCebolaCaramelizada);
            this.grpOpcionais.Controls.Add(this.chkQueijoExtra);
            this.grpOpcionais.Controls.Add(this.chkBacon);
            this.grpOpcionais.Location = new System.Drawing.Point(14, 95);
            this.grpOpcionais.Margin = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Padding = new System.Windows.Forms.Padding(2);
            this.grpOpcionais.Size = new System.Drawing.Size(146, 138);
            this.grpOpcionais.TabIndex = 22;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // chkTomate
            // 
            this.chkTomate.AutoSize = true;
            this.chkTomate.Location = new System.Drawing.Point(4, 94);
            this.chkTomate.Margin = new System.Windows.Forms.Padding(2);
            this.chkTomate.Name = "chkTomate";
            this.chkTomate.Size = new System.Drawing.Size(62, 17);
            this.chkTomate.TabIndex = 4;
            this.chkTomate.Text = "Tomate";
            this.chkTomate.UseVisualStyleBackColor = true;
            // 
            // chkCebolaCaramelizada
            // 
            this.chkCebolaCaramelizada.AutoSize = true;
            this.chkCebolaCaramelizada.Location = new System.Drawing.Point(4, 73);
            this.chkCebolaCaramelizada.Margin = new System.Windows.Forms.Padding(2);
            this.chkCebolaCaramelizada.Name = "chkCebolaCaramelizada";
            this.chkCebolaCaramelizada.Size = new System.Drawing.Size(125, 17);
            this.chkCebolaCaramelizada.TabIndex = 3;
            this.chkCebolaCaramelizada.Text = "Cebola Caramelizada";
            this.chkCebolaCaramelizada.UseVisualStyleBackColor = true;
            // 
            // chkQueijoExtra
            // 
            this.chkQueijoExtra.AutoSize = true;
            this.chkQueijoExtra.Location = new System.Drawing.Point(4, 52);
            this.chkQueijoExtra.Margin = new System.Windows.Forms.Padding(2);
            this.chkQueijoExtra.Name = "chkQueijoExtra";
            this.chkQueijoExtra.Size = new System.Drawing.Size(83, 17);
            this.chkQueijoExtra.TabIndex = 2;
            this.chkQueijoExtra.Text = "Queijo Extra";
            this.chkQueijoExtra.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(4, 31);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // lblValorHamburguer
            // 
            this.lblValorHamburguer.AutoSize = true;
            this.lblValorHamburguer.Location = new System.Drawing.Point(498, 69);
            this.lblValorHamburguer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorHamburguer.Name = "lblValorHamburguer";
            this.lblValorHamburguer.Size = new System.Drawing.Size(143, 13);
            this.lblValorHamburguer.TabIndex = 21;
            this.lblValorHamburguer.Text = "VALOR DO HAMBÚRGUER";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(438, 233);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(469, 122);
            this.dgvPedido.TabIndex = 20;
            // 
            // cmbTamanhoHamburguer
            // 
            this.cmbTamanhoHamburguer.FormattingEnabled = true;
            this.cmbTamanhoHamburguer.Location = new System.Drawing.Point(11, 49);
            this.cmbTamanhoHamburguer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTamanhoHamburguer.Name = "cmbTamanhoHamburguer";
            this.cmbTamanhoHamburguer.Size = new System.Drawing.Size(180, 21);
            this.cmbTamanhoHamburguer.TabIndex = 19;
            this.cmbTamanhoHamburguer.Text = "TAMANHO DO HAMBÚRGUER";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(496, 368);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(72, 32);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // chkAlface
            // 
            this.chkAlface.AutoSize = true;
            this.chkAlface.Location = new System.Drawing.Point(4, 115);
            this.chkAlface.Margin = new System.Windows.Forms.Padding(2);
            this.chkAlface.Name = "chkAlface";
            this.chkAlface.Size = new System.Drawing.Size(56, 17);
            this.chkAlface.TabIndex = 5;
            this.chkAlface.Text = "Alface";
            this.chkAlface.UseVisualStyleBackColor = true;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 468);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.txtCodPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.lblValorHamburguer);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbTamanhoHamburguer);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
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
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkTomate;
        private System.Windows.Forms.CheckBox chkCebolaCaramelizada;
        private System.Windows.Forms.CheckBox chkQueijoExtra;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.Label lblValorHamburguer;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.ComboBox cmbTamanhoHamburguer;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox chkAlface;
    }
}