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
    public partial class FrmUsuarioConsultarExcluir : Form
    {
        public FrmUsuarioConsultarExcluir()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
            Close();
        }

        private void menuUsuarioConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtPesquisar.Text;

            List<Usuario> Usuarios = usuario.GetUsuarioPor();
            dgvPesquisaUsuario.DataSource = Usuarios;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarioConsultarExcluir_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            List<Usuario> Usuarios = usuario.GetUsuario();
            dgvPesquisaUsuario.DataSource = Usuarios;
        }
    }
}
