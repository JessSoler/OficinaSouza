namespace Oficina
{
    partial class ProdutoListarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoListarForm));
            this.fecharButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.listarProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.excluirProdutoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listarProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(814, 409);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(4);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 28);
            this.fecharButton.TabIndex = 13;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(678, 409);
            this.novoButton.Margin = new System.Windows.Forms.Padding(4);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(100, 28);
            this.novoButton.TabIndex = 12;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            //this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(559, 409);
            this.alterarButton.Margin = new System.Windows.Forms.Padding(4);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(100, 28);
            this.alterarButton.TabIndex = 11;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(-95, 409);
            this.quantidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(77, 16);
            this.quantidadeLabel.TabIndex = 9;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // listarProdutoDataGridView
            // 
            this.listarProdutoDataGridView.AllowUserToAddRows = false;
            this.listarProdutoDataGridView.AllowUserToDeleteRows = false;
            this.listarProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.categoriaColumn,
            this.quantidadeColumn,
            this.valorColumn});
            this.listarProdutoDataGridView.Location = new System.Drawing.Point(0, 64);
            this.listarProdutoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.listarProdutoDataGridView.Name = "listarProdutoDataGridView";
            this.listarProdutoDataGridView.ReadOnly = true;
            this.listarProdutoDataGridView.RowHeadersWidth = 51;
            this.listarProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listarProdutoDataGridView.Size = new System.Drawing.Size(981, 306);
            this.listarProdutoDataGridView.TabIndex = 8;
            this.listarProdutoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "IDCodigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 80;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome do Produto";
            this.nomeColumn.MinimumWidth = 6;
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // categoriaColumn
            // 
            this.categoriaColumn.DataPropertyName = "Categoria";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.categoriaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriaColumn.HeaderText = "Categoria";
            this.categoriaColumn.MinimumWidth = 6;
            this.categoriaColumn.Name = "categoriaColumn";
            this.categoriaColumn.ReadOnly = true;
            this.categoriaColumn.Width = 80;
            // 
            // quantidadeColumn
            // 
            this.quantidadeColumn.DataPropertyName = "Quantidade";
            this.quantidadeColumn.HeaderText = "Quantidade";
            this.quantidadeColumn.MinimumWidth = 6;
            this.quantidadeColumn.Name = "quantidadeColumn";
            this.quantidadeColumn.ReadOnly = true;
            this.quantidadeColumn.Width = 125;
            // 
            // valorColumn
            // 
            this.valorColumn.DataPropertyName = "Valor";
            this.valorColumn.HeaderText = "Valor";
            this.valorColumn.MinimumWidth = 6;
            this.valorColumn.Name = "valorColumn";
            this.valorColumn.ReadOnly = true;
            this.valorColumn.Width = 125;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(-114, 13);
            this.listarButton.Margin = new System.Windows.Forms.Padding(4);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(100, 28);
            this.listarButton.TabIndex = 7;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // excluirProdutoButton
            // 
            this.excluirProdutoButton.Location = new System.Drawing.Point(430, 409);
            this.excluirProdutoButton.Margin = new System.Windows.Forms.Padding(4);
            this.excluirProdutoButton.Name = "excluirProdutoButton";
            this.excluirProdutoButton.Size = new System.Drawing.Size(100, 28);
            this.excluirProdutoButton.TabIndex = 16;
            this.excluirProdutoButton.Text = "Excluir";
            this.excluirProdutoButton.UseVisualStyleBackColor = true;
            //this.excluirProdutoButton.Click += new System.EventHandler(this.excluirProdutoButton_Click);
            // 
            // ProdutoListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.excluirProdutoButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.listarProdutoDataGridView);
            this.Controls.Add(this.listarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdutoListarForm";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.listarProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.DataGridView listarProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorColumn;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button excluirProdutoButton;
    }
}