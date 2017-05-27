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

        private int _codigo;
        private string _nome;
        private string _login;
        private string _senha;
        private string _perfil;
        private bool _status;

        public Usuario() {
        }

        public Usuario(string nome, string login, string senha, string perfil, bool status) {
            this._nome = nome;
            this._login = login;
            this._senha = senha;
            this._perfil = perfil;
            this._status = status;
        }

        public int Codigo {
             get
            {
                return this._codigo;
            }
            set
            { 
                this._codigo = value;
            }
            }

        public string Nome
            {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string Login
        {
            get
            {
                return this._login;
            }
            set
            {
                this._login = value;
            }
        }

        public string Senha
        {
            get
            {
                return this._senha;
            }
            set
            {
                this._senha = value;
            }
        }

        public string Perfil
        {
            get
            {
                return this._perfil;
            }
            set
            {
                this._perfil = value;
            }
        }

        public bool Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }


        public void Salvar() {
            bool inserir = (this._codigo == 0);

            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
            {
                cmd.CommandText = "INSET INTO Usuario" +
                    "loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                    "VALUES" +
                    "(@login, @senha, @nome, @perfil, @status)";

            }
            else {
                cmd.CommandText = "UPDATE Usuario " +
                    "SET loginUsurio = @login," +
                    "senhaUsuario = @senha, " +
                    "nomeUsuario = @nome, " +
                    "tipoPerfil = @perfil, " +
                    "usuarioAtivo = @status ";
            }

        }

        public List<Usuario> GetUsuario() {
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario";
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Usuario> Usuarios = new List<Usuario>();
            while (dr.Read()) {
                Usuario usuario = new Usuario();
                usuario._codigo = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                usuario._login = dr.GetString(dr.GetOrdinal("loginUsuario"));
                usuario._senha = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                usuario._nome = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                usuario._perfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                usuario._status = dr.GetBoolean(dr.GetOrdinal("usuarioAtivo"));
                Usuarios.Add(usuario);

            }

            cn.Close();
            cn.Dispose();

            return Usuarios;
        }
    }
}
