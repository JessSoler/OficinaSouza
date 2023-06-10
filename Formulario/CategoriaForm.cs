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

namespace Oficina.Formulario
{
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new CategoriaDAO().ListarTodas();

            categoriaDataGridView.DataSource = dados;
        }

        private void novoButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
