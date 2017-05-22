using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmProdutoConsultarExcluir : Form
    {
        public FrmProdutoConsultarExcluir()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void dgvGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Produto> Produtos = Produto.SelecionarProduto();
            dgvConsultaProduto.DataSource = Produtos;

        }
    }
}
