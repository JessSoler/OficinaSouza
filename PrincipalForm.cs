﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoX
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        void VerificarLogin()
        {
            if(Sessao.UsuarioLogado == null)
            {
                meuPerfilToolStripMenuItem.Enabled = false;

                loginToolStripButton.Text = "Entrar";
                loginToolStripButton.Image = ProjetoX.Properties.Resources.Aberto32;
                usuarioToolStripStatusLabel.Text = "Não autenticado";
                //barra
                categoriasToolStripButton.Enabled = false;
                produtosToolStripButton.Enabled = false;
                usuariosToolStripButton.Enabled = false;
                //menu
                categoriasToolStripMenuItem.Enabled = false;
                produtosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
            else
            {
                meuPerfilToolStripMenuItem.Enabled = true;

                loginToolStripButton.Text = "Sair";
                loginToolStripButton.Image = ProjetoX.Properties.Resources.Fechado48;

                usuarioToolStripStatusLabel.Text = Sessao.UsuarioLogado.Nome;
                //barra
                categoriasToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaCategorias;
                produtosToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaProdutos;
                usuariosToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;
                //menu
                categoriasToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaCategorias;
                produtosToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaProdutos;
                usuariosToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = null;
            VerificarLogin();

            new LoginForm().ShowDialog();

            VerificarLogin();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            VerificarLogin();
        }

        private void produtosToolStripButton_Click(object sender, EventArgs e)
        {
            ProdutoListarForm produtoListarForm = new ProdutoListarForm();
            produtoListarForm.MdiParent = this;
            produtoListarForm.Show();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado == null)
                return;

            new MeuPerfilForm().ShowDialog();

            VerificarLogin();
        }
    }
}
