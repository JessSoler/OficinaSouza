using ProjetoX.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoX
{
    public partial class MeuPerfilForm : Form
    {
        public MeuPerfilForm()
        {
            InitializeComponent();
            Application.DoEvents();

            idTextBox.Text = Sessao.UsuarioLogado.ID.ToString();
            nomeTextBox.Text = Sessao.UsuarioLogado.Nome;
            emailTextBox.Text = Sessao.UsuarioLogado.Email;

            if (Directory.Exists(Application.StartupPath + @"\Arquivos"))
            {
                if (File.Exists(Application.StartupPath + @"\Arquivos\" + Sessao.UsuarioLogado.ID + ".jpg"))
                    fotoPictureBox.Image = Image.FromFile(Application.StartupPath + @"\Arquivos\" + Sessao.UsuarioLogado.ID + ".jpg");
                else
                    fotoPictureBox.Image = ProjetoX.Properties.Resources.SemImagem;
            }
            else
                fotoPictureBox.Image = ProjetoX.Properties.Resources.SemImagem;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos jpg (*.jpg)|*.jpg";
                openFileDialog.Title = "Escolha a sua foto";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(Application.StartupPath + @"\Arquivos"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Arquivos");

                    File.Copy(openFileDialog.FileName, Application.StartupPath + @"\Arquivos\" + Sessao.UsuarioLogado.ID + ".jpg", true);

                    fotoPictureBox.Image = Image.FromFile(Application.StartupPath + @"\Arquivos\" + Sessao.UsuarioLogado.ID + ".jpg");
                }
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            if (!usuarioDAO.CompararSenhas(Sessao.UsuarioLogado.ID, senhaAtualTextBox.Text))
            {
                MessageBox.Show("Senha atual não confere!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                senhaAtualTextBox.Focus();
                return;
            }

                var usuario = Sessao.UsuarioLogado;
            usuario.Nome = nomeTextBox.Text.Trim();
            usuario.Email = emailTextBox.Text.Trim();

            //valida o email
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(usuario.Email);
            if (!match.Success)
            {
                MessageBox.Show("O email não é válido!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Focus();
                return;
            }

                //altera os dados
                usuarioDAO.AlterarPerfil(usuario);

            if (novaSenha1TextBox.Text.Length > 0)
            {
                if (novaSenha1TextBox.Text != novaSenha2TextBox.Text)
                {
                    MessageBox.Show("As novas senhas não conferem!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    novaSenha1TextBox.Clear();
                    novaSenha2TextBox.Clear();
                    novaSenha1TextBox.Focus();
                    return;
                }

                usuario.Senha = novaSenha1TextBox.Text.Trim();
                usuarioDAO.AlterarSenha(usuario);

            }

            MessageBox.Show("Dados alterados, refaça o login.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sessao.UsuarioLogado = null;
            Close();
        }
    }
}