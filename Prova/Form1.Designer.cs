namespace Prova
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridResultado = new System.Windows.Forms.DataGridView();
			this.lblCadastro = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblProfissão = new System.Windows.Forms.Label();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.lblAltura = new System.Windows.Forms.Label();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.txbProfissao = new System.Windows.Forms.TextBox();
			this.mskNascimento = new System.Windows.Forms.MaskedTextBox();
			this.mskAltura = new System.Windows.Forms.MaskedTextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblAlteradoExcluido = new System.Windows.Forms.Label();
			this.txbNomeAlteradoExcluido = new System.Windows.Forms.TextBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.lblQuantidadeCadastros = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridResultado)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridResultado
			// 
			this.dataGridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridResultado.Location = new System.Drawing.Point(12, 36);
			this.dataGridResultado.Name = "dataGridResultado";
			this.dataGridResultado.Size = new System.Drawing.Size(419, 402);
			this.dataGridResultado.TabIndex = 0;
			// 
			// lblCadastro
			// 
			this.lblCadastro.AutoSize = true;
			this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastro.Location = new System.Drawing.Point(453, 85);
			this.lblCadastro.Name = "lblCadastro";
			this.lblCadastro.Size = new System.Drawing.Size(74, 20);
			this.lblCadastro.TabIndex = 1;
			this.lblCadastro.Text = "Cadastro";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(454, 155);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome";
			// 
			// lblProfissão
			// 
			this.lblProfissão.AutoSize = true;
			this.lblProfissão.Location = new System.Drawing.Point(454, 199);
			this.lblProfissão.Name = "lblProfissão";
			this.lblProfissão.Size = new System.Drawing.Size(50, 13);
			this.lblProfissão.TabIndex = 3;
			this.lblProfissão.Text = "Profissão";
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(454, 241);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(104, 13);
			this.lblNascimento.TabIndex = 4;
			this.lblNascimento.Text = "Data de Nascimento";
			// 
			// lblAltura
			// 
			this.lblAltura.AutoSize = true;
			this.lblAltura.Location = new System.Drawing.Point(457, 284);
			this.lblAltura.Name = "lblAltura";
			this.lblAltura.Size = new System.Drawing.Size(34, 13);
			this.lblAltura.TabIndex = 5;
			this.lblAltura.Text = "Altura";
			// 
			// txbNome
			// 
			this.txbNome.Location = new System.Drawing.Point(460, 171);
			this.txbNome.Name = "txbNome";
			this.txbNome.Size = new System.Drawing.Size(241, 20);
			this.txbNome.TabIndex = 6;
			// 
			// txbProfissao
			// 
			this.txbProfissao.Location = new System.Drawing.Point(460, 215);
			this.txbProfissao.Name = "txbProfissao";
			this.txbProfissao.Size = new System.Drawing.Size(241, 20);
			this.txbProfissao.TabIndex = 7;
			// 
			// mskNascimento
			// 
			this.mskNascimento.Location = new System.Drawing.Point(460, 261);
			this.mskNascimento.Mask = "00/00/0000";
			this.mskNascimento.Name = "mskNascimento";
			this.mskNascimento.Size = new System.Drawing.Size(100, 20);
			this.mskNascimento.TabIndex = 8;
			this.mskNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// mskAltura
			// 
			this.mskAltura.Location = new System.Drawing.Point(460, 300);
			this.mskAltura.Mask = "0,00";
			this.mskAltura.Name = "mskAltura";
			this.mskAltura.Size = new System.Drawing.Size(78, 20);
			this.mskAltura.TabIndex = 9;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(633, 297);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 10;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
			// 
			// alterarToolStripMenuItem
			// 
			this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
			this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.alterarToolStripMenuItem.Text = "Alterar";
			this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
			// 
			// excluirToolStripMenuItem
			// 
			this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
			this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.excluirToolStripMenuItem.Text = "Excluir";
			this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
			// 
			// lblAlteradoExcluido
			// 
			this.lblAlteradoExcluido.AutoSize = true;
			this.lblAlteradoExcluido.Location = new System.Drawing.Point(454, 114);
			this.lblAlteradoExcluido.Name = "lblAlteradoExcluido";
			this.lblAlteradoExcluido.Size = new System.Drawing.Size(102, 13);
			this.lblAlteradoExcluido.TabIndex = 12;
			this.lblAlteradoExcluido.Text = "Nome a ser alterado";
			// 
			// txbNomeAlteradoExcluido
			// 
			this.txbNomeAlteradoExcluido.Location = new System.Drawing.Point(460, 130);
			this.txbNomeAlteradoExcluido.Name = "txbNomeAlteradoExcluido";
			this.txbNomeAlteradoExcluido.Size = new System.Drawing.Size(241, 20);
			this.txbNomeAlteradoExcluido.TabIndex = 13;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(714, 298);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 14;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(714, 127);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 15;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// lblQuantidadeCadastros
			// 
			this.lblQuantidadeCadastros.AutoSize = true;
			this.lblQuantidadeCadastros.Location = new System.Drawing.Point(457, 47);
			this.lblQuantidadeCadastros.Name = "lblQuantidadeCadastros";
			this.lblQuantidadeCadastros.Size = new System.Drawing.Size(0, 13);
			this.lblQuantidadeCadastros.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblQuantidadeCadastros);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.txbNomeAlteradoExcluido);
			this.Controls.Add(this.lblAlteradoExcluido);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.mskAltura);
			this.Controls.Add(this.mskNascimento);
			this.Controls.Add(this.txbProfissao);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.lblAltura);
			this.Controls.Add(this.lblNascimento);
			this.Controls.Add(this.lblProfissão);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblCadastro);
			this.Controls.Add(this.dataGridResultado);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridResultado)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridResultado;
		private System.Windows.Forms.Label lblCadastro;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblProfissão;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblAltura;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.TextBox txbProfissao;
		private System.Windows.Forms.MaskedTextBox mskNascimento;
		private System.Windows.Forms.MaskedTextBox mskAltura;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
		private System.Windows.Forms.Label lblAlteradoExcluido;
		private System.Windows.Forms.TextBox txbNomeAlteradoExcluido;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label lblQuantidadeCadastros;
	}
}

