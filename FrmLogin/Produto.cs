using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrmLogin
{
    class Produto
    {
        private int codigo;
        private string nome;
        private string descricao;
        private decimal preco;
        private decimal desconto;
        private bool status;
        private int estoqueMin;

        public Produto(string nome, string descricao, decimal preco, decimal desconto, bool status, int estoqueMin) {
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
            this.desconto = desconto;
            this.status = status;
            this.estoqueMin = estoqueMin;
        }

        public Produto(){
        }

        public int Codigo {
            get {
                return this.codigo;
            }
            set {
                this.codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }

        public decimal Preco
        {
            get
            {
                return this.preco;
            }
            set
            {
                this.preco = value;
            }
        }

        public decimal Desconto
        {
            get
            {
                return this.desconto;
            }
            set
            {
                this.desconto = value;
            }
        }

        public bool Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        public int Estoque
        {
            get
            {
                return this.estoqueMin;
            }
            set
            {
                this.estoqueMin = value;
            }
        }
        public List<Produto> SelecionarProduto() {

            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque FROM Produto";
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Produto> Produtos = new List<Produto>();
            while (dr.Read()) {
                Produto p = new Produto();
                p.codigo = dr.GetInt32(dr.GetOrdinal("idProduto"));
                p.nome = dr.GetString(dr.GetOrdinal("nomeProduto"));
                p.descricao = dr.GetString(dr.GetOrdinal("descProduto"));
                p.preco = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                p.desconto = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                p.status = true;//dr.GetBoolean(dr.GetOrdinal("ativoProduto"));
                p.estoqueMin = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                Produtos.Add(p);
            }

            cn.Close();
            cn.Dispose();

            return Produtos;
        }

    }
}
