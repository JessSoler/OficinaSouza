namespace Oficina.Formulario
{
    partial class CategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaForm));
            this.listarButton = new System.Windows.Forms.Button();
            this.categoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.fecharButton = new System.Windows.Forms.Button();
            this.excluirProdutoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.novaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(13, 13);
            this.listarButton.Margin = new System.Windows.Forms.Padding(4);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(100, 28);
            this.listarButton.TabIndex = 15;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // categoriaDataGridView
            // 
            this.categoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDataGridView.Location = new System.Drawing.Point(9, 66);
            this.categoriaDataGridView.Name = "categoriaDataGridView";
            this.categoriaDataGridView.RowHeadersWidth = 51;
            this.categoriaDataGridView.RowTemplate.Height = 24;
            this.categoriaDataGridView.Size = new System.Drawing.Size(779, 257);
            this.categoriaDataGridView.TabIndex = 16;
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(677, 398);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(4);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 28);
            this.fecharButton.TabIndex = 17;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // excluirProdutoButton
            // 
            this.excluirProdutoButton.Location = new System.Drawing.Point(350, 398);
            this.excluirProdutoButton.Margin = new System.Windows.Forms.Padding(4);
            this.excluirProdutoButton.Name = "excluirProdutoButton";
            this.excluirProdutoButton.Size = new System.Drawing.Size(100, 28);
            this.excluirProdutoButton.TabIndex = 18;
            this.excluirProdutoButton.Text = "Excluir";
            this.excluirProdutoButton.UseVisualStyleBackColor = true;
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(470, 398);
            this.alterarButton.Margin = new System.Windows.Forms.Padding(4);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(100, 28);
            this.alterarButton.TabIndex = 19;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            // 
            // novaButton
            // 
            this.novaButton.Location = new System.Drawing.Point(578, 398);
            this.novaButton.Margin = new System.Windows.Forms.Padding(4);
            this.novaButton.Name = "novaButton";
            this.novaButton.Size = new System.Drawing.Size(100, 28);
            this.novaButton.TabIndex = 20;
            this.novaButton.Text = "Novo";
            this.novaButton.UseVisualStyleBackColor = true;
            this.novaButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novaButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.excluirProdutoButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.categoriaDataGridView);
            this.Controls.Add(this.listarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriaForm";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.DataGridView categoriaDataGridView;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button excluirProdutoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button novaButton;
    }
}