using System.Drawing;

namespace MCPLOGViewer.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.txt_Logtext = new System.Windows.Forms.RichTextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_buscarLigacoes = new System.Windows.Forms.Button();
            this.lst_debugIDs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.palavrasImportantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diminuirFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separarPacotesSIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gbo_destaque = new System.Windows.Forms.GroupBox();
            this.rbt_sem_destaque = new System.Windows.Forms.RadioButton();
            this.rbt_destaque = new System.Windows.Forms.RadioButton();
            this.menuStrip2.SuspendLayout();
            this.gbo_destaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Por";
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(12, 50);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(129, 20);
            this.txt_busca.TabIndex = 4;
            // 
            // txt_Logtext
            // 
            this.txt_Logtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Logtext.Font = new System.Drawing.Font("Consolas", 10F);
            this.txt_Logtext.Location = new System.Drawing.Point(12, 153);
            this.txt_Logtext.Name = "txt_Logtext";
            this.txt_Logtext.ReadOnly = true;
            this.txt_Logtext.Size = new System.Drawing.Size(1398, 452);
            this.txt_Logtext.TabIndex = 11;
            this.txt_Logtext.Text = "";
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(12, 84);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(129, 23);
            this.btn_busca.TabIndex = 13;
            this.btn_busca.Text = "Buscar No(s) Arquivo(s)";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_buscarLigacoes
            // 
            this.btn_buscarLigacoes.Location = new System.Drawing.Point(12, 122);
            this.btn_buscarLigacoes.Name = "btn_buscarLigacoes";
            this.btn_buscarLigacoes.Size = new System.Drawing.Size(129, 23);
            this.btn_buscarLigacoes.TabIndex = 14;
            this.btn_buscarLigacoes.Text = "Buscar Ligações";
            this.btn_buscarLigacoes.UseVisualStyleBackColor = true;
            this.btn_buscarLigacoes.Click += new System.EventHandler(this.btn_juntarLigacoes_Click);
            // 
            // lst_debugIDs
            // 
            this.lst_debugIDs.FormattingEnabled = true;
            this.lst_debugIDs.Location = new System.Drawing.Point(156, 51);
            this.lst_debugIDs.Name = "lst_debugIDs";
            this.lst_debugIDs.Size = new System.Drawing.Size(144, 95);
            this.lst_debugIDs.TabIndex = 18;
            this.lst_debugIDs.SelectedIndexChanged += new System.EventHandler(this.lst_debugIDs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ligações Encontradas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArquivoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.mn_sair});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.abrirArquivoToolStripMenuItem.Text = "Abrir Arquivo";
            this.abrirArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem3.Text = "Salvar";
            // 
            // mn_sair
            // 
            this.mn_sair.Name = "mn_sair";
            this.mn_sair.Size = new System.Drawing.Size(145, 22);
            this.mn_sair.Text = "Sair";
            this.mn_sair.Click += new System.EventHandler(this.mn_sair_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palavrasImportantesToolStripMenuItem,
            this.aumentarFonteToolStripMenuItem,
            this.diminuirFonteToolStripMenuItem,
            this.separarPacotesSIPToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem2.Text = "Editar";
            // 
            // palavrasImportantesToolStripMenuItem
            // 
            this.palavrasImportantesToolStripMenuItem.Name = "palavrasImportantesToolStripMenuItem";
            this.palavrasImportantesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.palavrasImportantesToolStripMenuItem.Text = "Palavras importantes";
            this.palavrasImportantesToolStripMenuItem.Click += new System.EventHandler(this.palavrasImportantesToolStripMenuItem_Click);
            // 
            // aumentarFonteToolStripMenuItem
            // 
            this.aumentarFonteToolStripMenuItem.Name = "aumentarFonteToolStripMenuItem";
            this.aumentarFonteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aumentarFonteToolStripMenuItem.Text = "Aumentar Fonte";
            this.aumentarFonteToolStripMenuItem.Click += new System.EventHandler(this.aumentarFonteToolStripMenuItem_Click);
            // 
            // diminuirFonteToolStripMenuItem
            // 
            this.diminuirFonteToolStripMenuItem.Name = "diminuirFonteToolStripMenuItem";
            this.diminuirFonteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.diminuirFonteToolStripMenuItem.Text = "Diminuir Fonte";
            this.diminuirFonteToolStripMenuItem.Click += new System.EventHandler(this.diminuirFonteToolStripMenuItem_Click);
            // 
            // separarPacotesSIPToolStripMenuItem
            // 
            this.separarPacotesSIPToolStripMenuItem.Name = "separarPacotesSIPToolStripMenuItem";
            this.separarPacotesSIPToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.separarPacotesSIPToolStripMenuItem.Text = "Separar Pacotes SIP";
            this.separarPacotesSIPToolStripMenuItem.Click += new System.EventHandler(this.separarPacotesSIPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem5.Text = "Sobre";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1422, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gbo_destaque
            // 
            this.gbo_destaque.Controls.Add(this.rbt_sem_destaque);
            this.gbo_destaque.Controls.Add(this.rbt_destaque);
            this.gbo_destaque.Location = new System.Drawing.Point(332, 50);
            this.gbo_destaque.Name = "gbo_destaque";
            this.gbo_destaque.Size = new System.Drawing.Size(193, 87);
            this.gbo_destaque.TabIndex = 21;
            this.gbo_destaque.TabStop = false;
            this.gbo_destaque.Text = "Destaque em Palavras Importantes";
            // 
            // rbt_sem_destaque
            // 
            this.rbt_sem_destaque.AutoSize = true;
            this.rbt_sem_destaque.Location = new System.Drawing.Point(11, 49);
            this.rbt_sem_destaque.Name = "rbt_sem_destaque";
            this.rbt_sem_destaque.Size = new System.Drawing.Size(136, 17);
            this.rbt_sem_destaque.TabIndex = 1;
            this.rbt_sem_destaque.TabStop = true;
            this.rbt_sem_destaque.Text = "Sem Destaque no texto";
            this.rbt_sem_destaque.UseVisualStyleBackColor = true;
            this.rbt_sem_destaque.CheckedChanged += new System.EventHandler(this.rbt_sem_destaque_CheckedChanged);
            // 
            // rbt_destaque
            // 
            this.rbt_destaque.AutoSize = true;
            this.rbt_destaque.Location = new System.Drawing.Point(11, 26);
            this.rbt_destaque.Name = "rbt_destaque";
            this.rbt_destaque.Size = new System.Drawing.Size(112, 17);
            this.rbt_destaque.TabIndex = 0;
            this.rbt_destaque.TabStop = true;
            this.rbt_destaque.Text = "Destaque no texto";
            this.rbt_destaque.UseVisualStyleBackColor = true;
            this.rbt_destaque.CheckedChanged += new System.EventHandler(this.rbt_destaque_CheckedChanged);
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(1422, 617);
            this.Controls.Add(this.gbo_destaque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_debugIDs);
            this.Controls.Add(this.btn_buscarLigacoes);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.txt_Logtext);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Principal";
            this.Text = "MCPLog Viewer";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.gbo_destaque.ResumeLayout(false);
            this.gbo_destaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.RichTextBox txt_Logtext;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_buscarLigacoes;
        private System.Windows.Forms.ListBox lst_debugIDs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mn_sair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem palavrasImportantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diminuirFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separarPacotesSIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.GroupBox gbo_destaque;
        private System.Windows.Forms.RadioButton rbt_sem_destaque;
        private System.Windows.Forms.RadioButton rbt_destaque;
    }
}

