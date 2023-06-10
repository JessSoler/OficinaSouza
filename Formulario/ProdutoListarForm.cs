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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oficina
{
    public partial class ProdutoListarForm : Form
    {
        public ProdutoListarForm()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dados = new ProdutoDAO().ListarTodas();

            listarProdutoDataGridView.DataSource = dados;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void excluirProdutoButton_Click(object sender, EventArgs e)
        //{
        //    {
        //        if (MessageBox.Show("Confirma a exclusão do Produto?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {

        //            //executa a exclusão
        //            new ProdutoDAO().ExcluirProduto(Convert.ToInt32(idTextBox.Text));
        //            //avisa o usuário
        //            MessageBox.Show("Produto excluído com sucesso!", ProductName,
        //           MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

        //private void novoButton_Click(object sender, EventArgs e)
        //{
        //    //faz a inclusão
        //    new UsuarioDAO().Adicionar(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, Convert.ToBoolean(acessaCategoriasTextBox.Text), Convert.ToBoolean(acessaProdutosTextBox.Text), Convert.ToBoolean(acessaUsuariostextBox.Text), Convert.ToBoolean(ativoTextBox.Text));
        //    MessageBox.Show("Produto adicionado com sucesso!", ProductName,
        //   MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Close();
        //}
    }
}
