namespace MCPLOGViewer.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharArqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_files = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.txt_Logtext = new System.Windows.Forms.RichTextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_buscarLigacoes = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lst_debugIDs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArquivoToolStripMenuItem,
            this.abrirPastaToolStripMenuItem,
            this.fecharArqToolStripMenuItem,
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
            // abrirPastaToolStripMenuItem
            // 
            this.abrirPastaToolStripMenuItem.Name = "abrirPastaToolStripMenuItem";
            this.abrirPastaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.abrirPastaToolStripMenuItem.Text = "Abrir Pasta";
            this.abrirPastaToolStripMenuItem.Click += new System.EventHandler(this.abrirPastaToolStripMenuItem_Click);
            // 
            // fecharArqToolStripMenuItem
            // 
            this.fecharArqToolStripMenuItem.Name = "fecharArqToolStripMenuItem";
            this.fecharArqToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fecharArqToolStripMenuItem.Text = "Fechar Arq.";
            this.fecharArqToolStripMenuItem.Click += new System.EventHandler(this.fecharArqToolStripMenuItem_Click);
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
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem2.Text = "Ajuda";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem5.Text = "Sobre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arquivos";
            // 
            // lst_files
            // 
            this.lst_files.FormattingEnabled = true;
            this.lst_files.Location = new System.Drawing.Point(12, 53);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(794, 95);
            this.lst_files.TabIndex = 2;
            this.lst_files.SelectedIndexChanged += new System.EventHandler(this.lst_files_SelectedIndexChanged);
            this.lst_files.DoubleClick += new System.EventHandler(this.lst_files_SelectedIndexDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(920, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Por";
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(924, 52);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(129, 20);
            this.txt_busca.TabIndex = 4;
            this.txt_busca.TextChanged += new System.EventHandler(this.txt_busca_TextChanged);
            // 
            // txt_Logtext
            // 
            this.txt_Logtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Logtext.Location = new System.Drawing.Point(12, 153);
            this.txt_Logtext.Name = "txt_Logtext";
            this.txt_Logtext.ReadOnly = true;
            this.txt_Logtext.Size = new System.Drawing.Size(1312, 367);
            this.txt_Logtext.TabIndex = 11;
            this.txt_Logtext.Text = "";
            this.txt_Logtext.TextChanged += new System.EventHandler(this.txt_Logtext_TextChanged);
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(924, 86);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(129, 23);
            this.btn_busca.TabIndex = 13;
            this.btn_busca.Text = "Buscar No(s) Arquivo(s)";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_buscarLigacoes
            // 
            this.btn_buscarLigacoes.Location = new System.Drawing.Point(924, 124);
            this.btn_buscarLigacoes.Name = "btn_buscarLigacoes";
            this.btn_buscarLigacoes.Size = new System.Drawing.Size(129, 23);
            this.btn_buscarLigacoes.TabIndex = 14;
            this.btn_buscarLigacoes.Text = "Buscar Ligações";
            this.btn_buscarLigacoes.UseVisualStyleBackColor = true;
            this.btn_buscarLigacoes.Click += new System.EventHandler(this.btn_juntarLigacoes_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1336, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Text = global::MCPLOGViewer.Properties.Settings.Default.NomeArquivo;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel2.Text = "Arquivo";
            // 
            // lst_debugIDs
            // 
            this.lst_debugIDs.FormattingEnabled = true;
            this.lst_debugIDs.Location = new System.Drawing.Point(1075, 53);
            this.lst_debugIDs.Name = "lst_debugIDs";
            this.lst_debugIDs.Size = new System.Drawing.Size(194, 95);
            this.lst_debugIDs.TabIndex = 18;
            this.lst_debugIDs.SelectedIndexChanged += new System.EventHandler(this.lst_debugIDs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1071, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "CALL Leg IDs Encontrados";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(812, 79);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 36);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar Arquivos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1336, 532);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_debugIDs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_buscarLigacoes);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.txt_Logtext);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_files);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "MCPLog Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Disposed += new System.EventHandler(this.Form1_UnLoad);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mn_sair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_files;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.RichTextBox txt_Logtext;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_buscarLigacoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ListBox lst_debugIDs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fecharArqToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn_limpar;
    }
}

