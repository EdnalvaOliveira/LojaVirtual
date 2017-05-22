using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    class Usuario
    {

        private int codigo { get; set; }
        private string nome  { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string pefil { get; set; }
        private bool status { get; set; }

        private static Usuario referencia;

        public static Usuario getInstance() {

            if (referencia == null) {
                referencia = new Usuario();
            }
            return referencia;
        }

        public void Salvar() {
            bool inserir = (this.codigo == 0);

            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir) {
                cmd.CommandText = "INSET INTO Usuario" +
                    "loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                    "VALUES" +
                    "(@login, @senha, @nome, @perfil, @status)";

            }

        }

        public static List<Usuario> GetUsuario() {
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario";
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Usuario> Usuarios = new List<Usuario>();
            while (dr.Read()) {
                Usuario usuario = new Usuario();
                usuario.codigo = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                usuario.login = dr.GetString(dr.GetOrdinal("loginUsuario"));
                usuario.senha = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                usuario.nome = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                usuario.pefil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                usuario.status = dr.GetBoolean(dr.GetOrdinal("usuarioAtivo"));
                Usuarios.Add(usuario);

            }

            cn.Close();
            cn.Dispose();

            return Usuarios;
        }
    }
}
