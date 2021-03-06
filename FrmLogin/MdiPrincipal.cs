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
    public partial class MdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public MdiPrincipal()
        {
            InitializeComponent();

            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiAlterarProduto_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
        }

        private void tsmiCadastrarProduto_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void tsmiConsultarProduto_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
        }

        private void tsmiExcluirProduto_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
            
        }

        private void tsmiAlterarUsuario_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
        }

        private void tsmiCadastrarUsuario_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
        }

        private void tsmiConsultarUsuario_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
        }

        private void tsmiExcluirUsuario_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
        }

        private void tsmiTelaInicial_Click(object sender, EventArgs e)
        {
            ChamarTela.Inicial();
        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            ChamarTela.Login();
        }
    }
    }
