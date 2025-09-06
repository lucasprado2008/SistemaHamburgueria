using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaHamburgueria
{
    public partial class frmPedido : Form
    {
        // INSTANCIANDO A CLASSE DE CONEXÃO

        Conexao con = new Conexao();

        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            dgvListaPedido.Columns.Add("Item", "Item");
            dgvListaPedido.Columns.Add("Quantidade", "Qtd");
            dgvListaPedido.Columns.Add("Valor", "Valor (R$)");
            cmbTamanhoHamburguer.Items.Add("Mini - R$ 13,50");
            cmbTamanhoHamburguer.Items.Add("Médio - R$ 20,00");
            cmbTamanhoHamburguer.Items.Add("Grande - R$ 24,00");
            cmbTamanhoHamburguer.Items.Add("Super - R$ 29,00");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chkBacon.Checked = false;
            chkQueijoExtra.Checked = false;
            chkCebolaCaramelizada.Checked = false;
            chkTomate.Checked = false;
            chkAlface.Checked = false;
            txtValorOpcionais.Clear();
            txtValorHamburguer.Clear();
            txtValorPagar.Clear();
            txtCodPedido.Clear();
            txtCodPesquisar.Clear();
            dgvListaPedido.Rows.Clear();
            cmbTamanhoHamburguer.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS
            if (txtValorHamburguer.Text == "")
            {
                //EXIBE UMA MESSAGE BOX E DÁ FOCUS NO CAMPO VAZIO
                MessageBox.Show("Campo Obrigatório");
                txtValorHamburguer.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //TRATAMENTO DE ERROS
                try
                {
                    //INSERINDO DADOS NO BANCO DE DADOS
                    string sql = "insert into tbPedido(tipoHamburguer,valorHamburguer,valorOpcionais,valorTotal) values(@hamburguer,@vhamburguer,@vopcionais,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConectarBD());
                    cmd.Parameters.Add("@hamburguer", MySqlDbType.Text).Value = cmbTamanhoHamburguer.Text;
                    cmd.Parameters.Add("@vhamburguer", MySqlDbType.Text).Value = txtValorHamburguer.Text;
                    cmd.Parameters.Add("@vopcionais", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoHamburguer.Text = "";
                    txtValorHamburguer.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTamanhoHamburguer.Focus();
                    con.DesconectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            chkBacon.Checked = false;
            chkQueijoExtra.Checked = false;
            chkCebolaCaramelizada.Checked = false;
            chkTomate.Checked = false;
            chkAlface.Checked = false;
            cmbTamanhoHamburguer.SelectedIndex = 0;
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //DECLARANDO AS VARIAVEIS
            double valorHamburguer = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamanhoHamburguer.SelectedIndex == 0)
            {
                dgvListaPedido.Rows.Add("Hambúrguer Pequeno", 1, 13.50);
                valorHamburguer = 13.50;
            }
            else if (cmbTamanhoHamburguer.SelectedIndex == 1)
            {
                dgvListaPedido.Rows.Add("Hambúrguer Médio", 1, 20.00);
                valorHamburguer = 20;
            }
            else if (cmbTamanhoHamburguer.SelectedIndex == 2)
            {
                dgvListaPedido.Rows.Add("Hambúrguer Grande", 1, 24.00);
                valorHamburguer = 24;
            }
            else if (cmbTamanhoHamburguer.SelectedIndex == 3)
            {
                dgvListaPedido.Rows.Add("Hambúrguer Super", 1, 29.00);
                valorHamburguer = 29;
            }
            if (chkBacon.Checked == true)
            {
                dgvListaPedido.Rows.Add("Bacon", 1, 5.00);
                valorOpcao = valorOpcao + 4;
            }
            if (chkQueijoExtra.Checked == true)
            {
                dgvListaPedido.Rows.Add("Queijo Extra", 1, 2.50);
                valorOpcao = valorOpcao + 2.50;
            }
            if (chkCebolaCaramelizada.Checked == true)
            {
                dgvListaPedido.Rows.Add("Cebola Caramelizada", 1, 3.00);
                valorOpcao = valorOpcao + 3;
            }
            if (chkTomate.Checked == true)
            {
                dgvListaPedido.Rows.Add("Tomate", 1, 1.50);
                valorOpcao = valorOpcao + 1.50;
            }
            if (chkAlface.Checked == true)
            {
                dgvListaPedido.Rows.Add("Alface", 1, 1.50);
                valorOpcao = valorOpcao + 1.50;
            }
            else
            {

            }
            valorTotal = valorHamburguer + valorOpcao;
            txtValorHamburguer.Text = Convert.ToString(valorHamburguer);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // CRIANDO IF DE SAÍDA
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                frmPedido ped = new frmPedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                frmMenu menu = new frmMenu();
                this.Close();
                menu.Show();
            }
        }

        private void txtCodPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodPesquisar.Text != "")
            {
                try
                {
                    //CONECTA O BANCO
                    con.ConectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    //SELECIONA A TABELA
                    cmd.CommandText = "select * from tbPedido";
                    cmd.Connection = con.ConectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesconectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                //LIMPA O DATAGRID VIEW
                dgvPedido.DataSource = null;
            }
        }

        public void CarregarPedidos()
        {
            try
            {
                //VALOR DA POSIÇÃO DA MEMÓRIA 0 0
                txtCodPedido.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanhoHamburguer.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                txtValorHamburguer.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                txtValorOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                txtValorPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarPedidos();
        }

        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
            chkBacon.Checked = false;
            chkQueijoExtra.Checked = false;
            chkCebolaCaramelizada.Checked = false;
            chkTomate.Checked = false;
            chkAlface.Checked = false;
        }
    }
}
