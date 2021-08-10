
namespace DesafioNF_v1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.gênerosToolStripMenuItem,
            this.autoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
            this.exibirLivrosToolStripMenuItem,
            this.buscarLivrosToolStripMenuItem,
            this.locarLivrosToolStripMenuItem});
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livroToolStripMenuItem.Text = "Livros";
            // 
            // cadastrarLivroToolStripMenuItem
            // 
            this.cadastrarLivroToolStripMenuItem.Name = "cadastrarLivroToolStripMenuItem";
            this.cadastrarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLivroToolStripMenuItem.Text = "Cadastrar livro";
            this.cadastrarLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLivroToolStripMenuItem_Click);
            // 
            // exibirLivrosToolStripMenuItem
            // 
            this.exibirLivrosToolStripMenuItem.Name = "exibirLivrosToolStripMenuItem";
            this.exibirLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirLivrosToolStripMenuItem.Text = "Exibir livros";
            // 
            // buscarLivrosToolStripMenuItem
            // 
            this.buscarLivrosToolStripMenuItem.Name = "buscarLivrosToolStripMenuItem";
            this.buscarLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarLivrosToolStripMenuItem.Text = "Buscar livros";
            // 
            // gênerosToolStripMenuItem
            // 
            this.gênerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarGênerosToolStripMenuItem,
            this.exibirGênerosToolStripMenuItem,
            this.buscarGênerosToolStripMenuItem});
            this.gênerosToolStripMenuItem.Name = "gênerosToolStripMenuItem";
            this.gênerosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gênerosToolStripMenuItem.Text = "Gêneros";
            // 
            // cadastrarGênerosToolStripMenuItem
            // 
            this.cadastrarGênerosToolStripMenuItem.Name = "cadastrarGênerosToolStripMenuItem";
            this.cadastrarGênerosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cadastrarGênerosToolStripMenuItem.Text = "Cadastrar gêneros";
            // 
            // exibirGênerosToolStripMenuItem
            // 
            this.exibirGênerosToolStripMenuItem.Name = "exibirGênerosToolStripMenuItem";
            this.exibirGênerosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exibirGênerosToolStripMenuItem.Text = "Exibir gêneros";
            // 
            // buscarGênerosToolStripMenuItem
            // 
            this.buscarGênerosToolStripMenuItem.Name = "buscarGênerosToolStripMenuItem";
            this.buscarGênerosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.buscarGênerosToolStripMenuItem.Text = "Buscar gêneros";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAutoresToolStripMenuItem,
            this.exibirAutoresToolStripMenuItem,
            this.buscarAutoresToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // cadastrarAutoresToolStripMenuItem
            // 
            this.cadastrarAutoresToolStripMenuItem.Name = "cadastrarAutoresToolStripMenuItem";
            this.cadastrarAutoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cadastrarAutoresToolStripMenuItem.Text = "Cadastrar autores";
            // 
            // exibirAutoresToolStripMenuItem
            // 
            this.exibirAutoresToolStripMenuItem.Name = "exibirAutoresToolStripMenuItem";
            this.exibirAutoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exibirAutoresToolStripMenuItem.Text = "Exibir autores";
            // 
            // buscarAutoresToolStripMenuItem
            // 
            this.buscarAutoresToolStripMenuItem.Name = "buscarAutoresToolStripMenuItem";
            this.buscarAutoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.buscarAutoresToolStripMenuItem.Text = "Buscar autores";
            // 
            // locarLivrosToolStripMenuItem
            // 
            this.locarLivrosToolStripMenuItem.Name = "locarLivrosToolStripMenuItem";
            this.locarLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locarLivrosToolStripMenuItem.Text = "Locar livros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(551, 294);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Biblioteca_System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locarLivrosToolStripMenuItem;
    }
}

