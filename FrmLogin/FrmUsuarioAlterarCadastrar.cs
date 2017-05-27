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
    public partial class FrmUsuarioAlterarCadastrar : Form
    {
        public FrmUsuarioAlterarCadastrar()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string login = Convert.ToString(txtLogin);
            string senha = Convert.ToString(txtSenha);
            string nome = Convert.ToString(txtNome);
            string perfil = Convert.ToString(CboPerfil);
            bool ativo = rbtStatusAtivado.Checked;

            Usuario usuario = new Usuario(nome, login, senha, perfil, ativo);
            //usuario.Codigo = Convert.ToInt32(txtCodigo);
            usuario.Login = Convert.ToString(txtLogin);
            usuario.Senha = Convert.ToString(txtSenha);
            usuario.Nome = Convert.ToString(txtNome);
            usuario.Perfil = Convert.ToString(CboPerfil);
            if (rbtStatusAtivado.Checked)
            {
                usuario.Status = true;
            }
            else {
                usuario.Status = false;
            }

            usuario.Salvar();
        }
    }
}
