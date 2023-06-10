using Oficina;
using Oficina.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
                //faz a inclusão
                new UsuarioDAO().Adicionar(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, Convert.ToBoolean(acessaCategoriasTextBox.Text), Convert.ToBoolean(acessaProdutosTextBox.Text), Convert.ToBoolean(acessaUsuariostextBox.Text), Convert.ToBoolean(ativoTextBox.Text));
                MessageBox.Show("Produto adicionado com sucesso!", ProductName,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
               Close();

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new UsuarioDAO().ListarTodas();

            usuarioListarDataGridView.DataSource = dados;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
