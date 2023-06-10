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
    public partial class ProdutoListarForm : Form
    {
        public ProdutoListarForm()
        {
            InitializeComponent();
          
        }

        private void ProdutoListarForm_Shown(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado == null || Sessao.UsuarioLogado.AcessaProdutos == false)
            {
                MessageBox.Show("Você não tem acesso a esta área!",
                 ProductName,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

                Close();
            }
        }
    }
}
