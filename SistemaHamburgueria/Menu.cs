using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHamburgueria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // CRIANDO IF DE SAÍDA
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
