﻿namespace FrmLogin
{
    partial class MdiPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsmiTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcluirUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduto,
            this.usuárioToolStripMenuItem,
            this.tsmiTelaInicial});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // tsmiTelaInicial
            // 
            this.tsmiTelaInicial.Name = "tsmiTelaInicial";
            this.tsmiTelaInicial.Size = new System.Drawing.Size(75, 20);
            this.tsmiTelaInicial.Text = "Tela Inicial";
            this.tsmiTelaInicial.Click += new System.EventHandler(this.tsmiTelaInicial_Click);
            // 
            // tsmiAlterarUsuario
            // 
            this.tsmiAlterarUsuario.Name = "tsmiAlterarUsuario";
            this.tsmiAlterarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiAlterarUsuario.Text = "Alterar";
            this.tsmiAlterarUsuario.Click += new System.EventHandler(this.tsmiAlterarUsuario_Click);
            // 
            // tsmiCadastrarUsuario
            // 
            this.tsmiCadastrarUsuario.Name = "tsmiCadastrarUsuario";
            this.tsmiCadastrarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadastrarUsuario.Text = "Cadastrar";
            this.tsmiCadastrarUsuario.Click += new System.EventHandler(this.tsmiCadastrarUsuario_Click);
            // 
            // tsmiConsultarUsuario
            // 
            this.tsmiConsultarUsuario.Name = "tsmiConsultarUsuario";
            this.tsmiConsultarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiConsultarUsuario.Text = "Consultar";
            this.tsmiConsultarUsuario.Click += new System.EventHandler(this.tsmiConsultarUsuario_Click);
            // 
            // tsmiExcluirUsuario
            // 
            this.tsmiExcluirUsuario.Name = "tsmiExcluirUsuario";
            this.tsmiExcluirUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiExcluirUsuario.Text = "Excluir";
            this.tsmiExcluirUsuario.Click += new System.EventHandler(this.tsmiExcluirUsuario_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlterarUsuario,
            this.tsmiCadastrarUsuario,
            this.tsmiConsultarUsuario,
            this.tsmiExcluirUsuario});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // tsmiAlterarProduto
            // 
            this.tsmiAlterarProduto.Name = "tsmiAlterarProduto";
            this.tsmiAlterarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiAlterarProduto.Text = "Alterar";
            this.tsmiAlterarProduto.Click += new System.EventHandler(this.tsmiAlterarProduto_Click);
            // 
            // tsmiCadastrarProduto
            // 
            this.tsmiCadastrarProduto.Name = "tsmiCadastrarProduto";
            this.tsmiCadastrarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadastrarProduto.Text = "Cadastrar";
            this.tsmiCadastrarProduto.Click += new System.EventHandler(this.tsmiCadastrarProduto_Click);
            // 
            // tsmiConsultarProduto
            // 
            this.tsmiConsultarProduto.Name = "tsmiConsultarProduto";
            this.tsmiConsultarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiConsultarProduto.Text = "Consultar";
            this.tsmiConsultarProduto.Click += new System.EventHandler(this.tsmiConsultarProduto_Click);
            // 
            // tsmiExcluirProduto
            // 
            this.tsmiExcluirProduto.Name = "tsmiExcluirProduto";
            this.tsmiExcluirProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiExcluirProduto.Text = "Excluir";
            this.tsmiExcluirProduto.Click += new System.EventHandler(this.tsmiExcluirProduto_Click);
            // 
            // tsmiProduto
            // 
            this.tsmiProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlterarProduto,
            this.tsmiCadastrarProduto,
            this.tsmiConsultarProduto,
            this.tsmiExcluirProduto});
            this.tsmiProduto.Name = "tsmiProduto";
            this.tsmiProduto.Size = new System.Drawing.Size(62, 20);
            this.tsmiProduto.Text = "Produto";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MdiPrincipal";
            this.Text = "Hippo Mercado";
            this.Load += new System.EventHandler(this.MdiPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcluirProduto;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcluirUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiTelaInicial;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}



