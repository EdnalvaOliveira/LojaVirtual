﻿using System;
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
    public partial class FrmProdutoAlterarCadastrar : Form
    {
        public FrmProdutoAlterarCadastrar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Outros"))
            {
                ChamarTela.CategoriaCrud();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
            
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

        
        
        private void menuProdutoAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void menuProdutoCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void menuProdutoConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
            Close();
        }


        private void FrmProdutoAlterarCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
