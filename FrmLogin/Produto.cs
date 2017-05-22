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

        private static Produto referencia;
 
        public static Produto GetInstance() {
            if (referencia == null)
                referencia = new Produto();

            return referencia;
        }


        public static List<Produto> SelecionarProduto() {

            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, imagemProduto, ativoProduto, idUsuario, qtdMinEstoque FROM Produto";
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
                p.desconto = dr.GetDecimal(dr.GetOrdinal("descontoProduto"));
                p.status = dr.GetBoolean(dr.GetOrdinal("ativoProduto"));
                p.estoqueMin = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                Produtos.Add(p);
            }

            cn.Close();
            cn.Dispose();

            return Produtos;
        }

    }
}
