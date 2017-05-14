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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            
            InitializeComponent();

        }

      

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
            
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
