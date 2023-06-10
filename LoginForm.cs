using ProjetoX.Negocios;
using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Application.DoEvents();
            loginTextBox.Text = ProjetoX.Properties.Settings.Default.email;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = new UsuarioDAO().Login(loginTextBox.Text, senhaTextBox.Text);

            if(Sessao.UsuarioLogado == null)
            {
                loginTextBox.Focus();
                senhaTextBox.Clear();

                MessageBox.Show("Usuário ou senha inválido!", 
                    ProductName, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
               
                return;
            }
            else if(Sessao.UsuarioLogado.Ativo == false)
            {
                Sessao.UsuarioLogado = null;

                MessageBox.Show("O usuário está inativo. Procure o RH.",
                 ProductName,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }

            ProjetoX.Properties.Settings.Default.email = loginTextBox.Text;
            ProjetoX.Properties.Settings.Default.Save();

            Close();
        }
    }
}
