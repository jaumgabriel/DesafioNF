
namespace DesafioNF_v2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar livros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar gêneros";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Listar autores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livorsToolStripMenuItem,
            this.gênerosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livorsToolStripMenuItem
            // 
            this.livorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivrosToolStripMenuItem,
            this.removerLivrosToolStripMenuItem});
            this.livorsToolStripMenuItem.Name = "livorsToolStripMenuItem";
            this.livorsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livorsToolStripMenuItem.Text = "Livros";
            // 
            // gênerosToolStripMenuItem
            // 
            this.gênerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarGênerosToolStripMenuItem,
            this.removerGênerosToolStripMenuItem});
            this.gênerosToolStripMenuItem.Name = "gênerosToolStripMenuItem";
            this.gênerosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gênerosToolStripMenuItem.Text = "Gêneros";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAutoresToolStripMenuItem,
            this.removerAutoresToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // cadastrarLivrosToolStripMenuItem
            // 
            this.cadastrarLivrosToolStripMenuItem.Name = "cadastrarLivrosToolStripMenuItem";
            this.cadastrarLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLivrosToolStripMenuItem.Text = "Cadastrar livros";
            // 
            // removerLivrosToolStripMenuItem
            // 
            this.removerLivrosToolStripMenuItem.Name = "removerLivrosToolStripMenuItem";
            this.removerLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerLivrosToolStripMenuItem.Text = "Remover livros";
            // 
            // cadastrarGênerosToolStripMenuItem
            // 
            this.cadastrarGênerosToolStripMenuItem.Name = "cadastrarGênerosToolStripMenuItem";
            this.cadastrarGênerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarGênerosToolStripMenuItem.Text = "Cadastrar gêneros";
            this.cadastrarGênerosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarGênerosToolStripMenuItem_Click);
            // 
            // removerGênerosToolStripMenuItem
            // 
            this.removerGênerosToolStripMenuItem.Name = "removerGênerosToolStripMenuItem";
            this.removerGênerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerGênerosToolStripMenuItem.Text = "Remover gêneros";
            // 
            // cadastrarAutoresToolStripMenuItem
            // 
            this.cadastrarAutoresToolStripMenuItem.Name = "cadastrarAutoresToolStripMenuItem";
            this.cadastrarAutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAutoresToolStripMenuItem.Text = "Cadastrar autores";
            this.cadastrarAutoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAutoresToolStripMenuItem_Click);
            // 
            // removerAutoresToolStripMenuItem
            // 
            this.removerAutoresToolStripMenuItem.Name = "removerAutoresToolStripMenuItem";
            this.removerAutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerAutoresToolStripMenuItem.Text = "Remover autores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 310);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(821, 368);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca_System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

