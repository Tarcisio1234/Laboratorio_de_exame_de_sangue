namespace Nozama
{
    partial class menuNozama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuNozama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueSeuExameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaDoProfissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDoProfissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaDeComoUsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDaGerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faleConoscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cliqueAquiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.telaDoProfissionalToolStripMenuItem,
            this.ajudaDeComoUsarToolStripMenuItem,
            this.faleConoscoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDoClienteToolStripMenuItem,
            this.buscarCadastroToolStripMenuItem,
            this.editarCadastroToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastroDoClienteToolStripMenuItem
            // 
            this.cadastroDoClienteToolStripMenuItem.Name = "cadastroDoClienteToolStripMenuItem";
            this.cadastroDoClienteToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.cadastroDoClienteToolStripMenuItem.Text = "Cadastro do Cliente";
            this.cadastroDoClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoClienteToolStripMenuItem_Click);
            // 
            // buscarCadastroToolStripMenuItem
            // 
            this.buscarCadastroToolStripMenuItem.Name = "buscarCadastroToolStripMenuItem";
            this.buscarCadastroToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.buscarCadastroToolStripMenuItem.Text = "Buscar Cadastro";
            this.buscarCadastroToolStripMenuItem.Click += new System.EventHandler(this.buscarCadastroToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marqueSeuExameToolStripMenuItem});
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.buscarToolStripMenuItem.Text = "Agenda";
            // 
            // marqueSeuExameToolStripMenuItem
            // 
            this.marqueSeuExameToolStripMenuItem.Name = "marqueSeuExameToolStripMenuItem";
            this.marqueSeuExameToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.marqueSeuExameToolStripMenuItem.Text = "Marque seu exame";
            this.marqueSeuExameToolStripMenuItem.Click += new System.EventHandler(this.marqueSeuExameToolStripMenuItem_Click);
            // 
            // telaDoProfissionalToolStripMenuItem
            // 
            this.telaDoProfissionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaDoProfissionalToolStripMenuItem});
            this.telaDoProfissionalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telaDoProfissionalToolStripMenuItem.Name = "telaDoProfissionalToolStripMenuItem";
            this.telaDoProfissionalToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.telaDoProfissionalToolStripMenuItem.Text = "Tela do profissional";
            // 
            // agendaDoProfissionalToolStripMenuItem
            // 
            this.agendaDoProfissionalToolStripMenuItem.Name = "agendaDoProfissionalToolStripMenuItem";
            this.agendaDoProfissionalToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.agendaDoProfissionalToolStripMenuItem.Text = "Agenda do profissional";
            this.agendaDoProfissionalToolStripMenuItem.Click += new System.EventHandler(this.agendaDoProfissionalToolStripMenuItem_Click);
            // 
            // ajudaDeComoUsarToolStripMenuItem
            // 
            this.ajudaDeComoUsarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDaGerenciaToolStripMenuItem});
            this.ajudaDeComoUsarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ajudaDeComoUsarToolStripMenuItem.Name = "ajudaDeComoUsarToolStripMenuItem";
            this.ajudaDeComoUsarToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.ajudaDeComoUsarToolStripMenuItem.Text = "Gerência";
            // 
            // menuDaGerenciaToolStripMenuItem
            // 
            this.menuDaGerenciaToolStripMenuItem.Name = "menuDaGerenciaToolStripMenuItem";
            this.menuDaGerenciaToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.menuDaGerenciaToolStripMenuItem.Text = "Menu da Gerencia";
            this.menuDaGerenciaToolStripMenuItem.Click += new System.EventHandler(this.menuDaGerenciaToolStripMenuItem_Click);
            // 
            // faleConoscoToolStripMenuItem
            // 
            this.faleConoscoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cliqueAquiToolStripMenuItem});
            this.faleConoscoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.faleConoscoToolStripMenuItem.Name = "faleConoscoToolStripMenuItem";
            this.faleConoscoToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.faleConoscoToolStripMenuItem.Text = "Suporte";
            // 
            // cliqueAquiToolStripMenuItem
            // 
            this.cliqueAquiToolStripMenuItem.Name = "cliqueAquiToolStripMenuItem";
            this.cliqueAquiToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.cliqueAquiToolStripMenuItem.Text = "Contato do suporte";
            this.cliqueAquiToolStripMenuItem.Click += new System.EventHandler(this.cliqueAquiToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSair.Location = new System.Drawing.Point(687, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 47);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuNozama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 500);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "menuNozama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.menuNozama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marqueSeuExameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaDoProfissionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDoProfissionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faleConoscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cliqueAquiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaDeComoUsarToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem menuDaGerenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
    }
}

