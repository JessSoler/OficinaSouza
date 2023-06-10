namespace Oficina
{
    partial class UsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.fecharButton = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.usuarioListarDataGridView = new System.Windows.Forms.DataGridView();
            this.salvarButton = new System.Windows.Forms.Button();
            this.acessaCategoriasLabel = new System.Windows.Forms.Label();
            this.acessaCategoriasTextBox = new System.Windows.Forms.TextBox();
            this.acessaProdutosLabel = new System.Windows.Forms.Label();
            this.acessaUsuariosLabel = new System.Windows.Forms.Label();
            this.acessaUsuariostextBox = new System.Windows.Forms.TextBox();
            this.acessaProdutosTextBox = new System.Windows.Forms.TextBox();
            this.listarButton = new System.Windows.Forms.Button();
            this.ativoLabel = new System.Windows.Forms.Label();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioListarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(649, 409);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(4);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 28);
            this.fecharButton.TabIndex = 17;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(29, 204);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTextBox.MaxLength = 50;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '#';
            this.senhaTextBox.Size = new System.Drawing.Size(172, 22);
            this.senhaTextBox.TabIndex = 26;
            this.senhaTextBox.TextChanged += new System.EventHandler(this.senhaTextBox_TextChanged);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(25, 184);
            this.senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(46, 16);
            this.senhaLabel.TabIndex = 25;
            this.senhaLabel.Text = "Senha";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(25, 156);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(375, 22);
            this.emailTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 136);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 16);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(25, 108);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.MaxLength = 50;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(375, 22);
            this.nomeTextBox.TabIndex = 22;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(21, 88);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(44, 16);
            this.nomeLabel.TabIndex = 21;
            this.nomeLabel.Text = "Nome";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(25, 60);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(105, 22);
            this.idTextBox.TabIndex = 20;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(21, 40);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 16);
            this.idLabel.TabIndex = 19;
            this.idLabel.Text = "ID";
            // 
            // usuarioListarDataGridView
            // 
            this.usuarioListarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioListarDataGridView.Location = new System.Drawing.Point(484, 60);
            this.usuarioListarDataGridView.Name = "usuarioListarDataGridView";
            this.usuarioListarDataGridView.RowHeadersWidth = 51;
            this.usuarioListarDataGridView.RowTemplate.Height = 24;
            this.usuarioListarDataGridView.Size = new System.Drawing.Size(304, 324);
            this.usuarioListarDataGridView.TabIndex = 28;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(541, 409);
            this.salvarButton.Margin = new System.Windows.Forms.Padding(4);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(100, 28);
            this.salvarButton.TabIndex = 29;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // acessaCategoriasLabel
            // 
            this.acessaCategoriasLabel.AutoSize = true;
            this.acessaCategoriasLabel.Location = new System.Drawing.Point(25, 241);
            this.acessaCategoriasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acessaCategoriasLabel.Name = "acessaCategoriasLabel";
            this.acessaCategoriasLabel.Size = new System.Drawing.Size(122, 16);
            this.acessaCategoriasLabel.TabIndex = 30;
            this.acessaCategoriasLabel.Text = "Acessa Categorias";
            // 
            // acessaCategoriasTextBox
            // 
            this.acessaCategoriasTextBox.Location = new System.Drawing.Point(24, 261);
            this.acessaCategoriasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.acessaCategoriasTextBox.MaxLength = 50;
            this.acessaCategoriasTextBox.Name = "acessaCategoriasTextBox";
            this.acessaCategoriasTextBox.Size = new System.Drawing.Size(177, 22);
            this.acessaCategoriasTextBox.TabIndex = 31;
            // 
            // acessaProdutosLabel
            // 
            this.acessaProdutosLabel.AutoSize = true;
            this.acessaProdutosLabel.Location = new System.Drawing.Point(26, 297);
            this.acessaProdutosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acessaProdutosLabel.Name = "acessaProdutosLabel";
            this.acessaProdutosLabel.Size = new System.Drawing.Size(110, 16);
            this.acessaProdutosLabel.TabIndex = 32;
            this.acessaProdutosLabel.Text = "Acessa Produtos";
            // 
            // acessaUsuariosLabel
            // 
            this.acessaUsuariosLabel.AutoSize = true;
            this.acessaUsuariosLabel.Location = new System.Drawing.Point(26, 348);
            this.acessaUsuariosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acessaUsuariosLabel.Name = "acessaUsuariosLabel";
            this.acessaUsuariosLabel.Size = new System.Drawing.Size(110, 16);
            this.acessaUsuariosLabel.TabIndex = 33;
            this.acessaUsuariosLabel.Text = "Acessa Usuarios";
            // 
            // acessaUsuariostextBox
            // 
            this.acessaUsuariostextBox.Location = new System.Drawing.Point(24, 368);
            this.acessaUsuariostextBox.Margin = new System.Windows.Forms.Padding(4);
            this.acessaUsuariostextBox.MaxLength = 50;
            this.acessaUsuariostextBox.Name = "acessaUsuariostextBox";
            this.acessaUsuariostextBox.Size = new System.Drawing.Size(177, 22);
            this.acessaUsuariostextBox.TabIndex = 34;
            // 
            // acessaProdutosTextBox
            // 
            this.acessaProdutosTextBox.Location = new System.Drawing.Point(25, 317);
            this.acessaProdutosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.acessaProdutosTextBox.MaxLength = 50;
            this.acessaProdutosTextBox.Name = "acessaProdutosTextBox";
            this.acessaProdutosTextBox.Size = new System.Drawing.Size(177, 22);
            this.acessaProdutosTextBox.TabIndex = 35;
            this.acessaProdutosTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // listarButton
            // 
            this.listarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarButton.Location = new System.Drawing.Point(581, 21);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(156, 23);
            this.listarButton.TabIndex = 36;
            this.listarButton.Text = "Listar Usuário";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // ativoLabel
            // 
            this.ativoLabel.AutoSize = true;
            this.ativoLabel.Location = new System.Drawing.Point(25, 394);
            this.ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ativoLabel.Name = "ativoLabel";
            this.ativoLabel.Size = new System.Drawing.Size(37, 16);
            this.ativoLabel.TabIndex = 37;
            this.ativoLabel.Text = "Ativo";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.Location = new System.Drawing.Point(24, 415);
            this.ativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoTextBox.MaxLength = 50;
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(177, 22);
            this.ativoTextBox.TabIndex = 38;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.ativoLabel);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.acessaProdutosTextBox);
            this.Controls.Add(this.acessaUsuariostextBox);
            this.Controls.Add(this.acessaUsuariosLabel);
            this.Controls.Add(this.acessaProdutosLabel);
            this.Controls.Add(this.acessaCategoriasTextBox);
            this.Controls.Add(this.acessaCategoriasLabel);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.usuarioListarDataGridView);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.fecharButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioForm";
            this.Text = "Cadastro de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioListarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView usuarioListarDataGridView;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Label acessaCategoriasLabel;
        private System.Windows.Forms.TextBox acessaCategoriasTextBox;
        private System.Windows.Forms.Label acessaProdutosLabel;
        private System.Windows.Forms.Label acessaUsuariosLabel;
        private System.Windows.Forms.TextBox acessaUsuariostextBox;
        private System.Windows.Forms.TextBox acessaProdutosTextBox;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Label ativoLabel;
        private System.Windows.Forms.TextBox ativoTextBox;
    }
}