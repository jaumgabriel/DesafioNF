
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
            this.locarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.gênerosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
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
            // locarLivrosToolStripMenuItem
            // 
            this.locarLivrosToolStripMenuItem.Name = "locarLivrosToolStripMenuItem";
            this.locarLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locarLivrosToolStripMenuItem.Text = "Locar livros";
            // 
            // gênerosToolStripMenuItem
            // 
            this.gênerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarGênerosToolStripMenuItem});
            this.gênerosToolStripMenuItem.Name = "gênerosToolStripMenuItem";
            this.gênerosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gênerosToolStripMenuItem.Text = "Gêneros";
            // 
            // cadastrarGênerosToolStripMenuItem
            // 
            this.cadastrarGênerosToolStripMenuItem.Name = "cadastrarGênerosToolStripMenuItem";
            this.cadastrarGênerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarGênerosToolStripMenuItem.Text = "Cadastrar gêneros";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAutoresToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // cadastrarAutoresToolStripMenuItem
            // 
            this.cadastrarAutoresToolStripMenuItem.Name = "cadastrarAutoresToolStripMenuItem";
            this.cadastrarAutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAutoresToolStripMenuItem.Text = "Cadastrar autores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listar Livros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Listar Gêneros";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "Listar Autores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(514, 294);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem gênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locarLivrosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}

