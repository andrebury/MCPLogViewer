namespace MCPLOGViewer.View
{
    partial class LogFiltrado
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirNoNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_logFiltrado = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarComoToolStripMenuItem,
            this.abrirNoNotepadToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // abrirNoNotepadToolStripMenuItem
            // 
            this.abrirNoNotepadToolStripMenuItem.Name = "abrirNoNotepadToolStripMenuItem";
            this.abrirNoNotepadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.abrirNoNotepadToolStripMenuItem.Text = "Abrir no Notepad++";
            this.abrirNoNotepadToolStripMenuItem.Click += new System.EventHandler(this.abrirNoNotepadToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aumentarFonteToolStripMenuItem,
            this.fontSizeToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // aumentarFonteToolStripMenuItem
            // 
            this.aumentarFonteToolStripMenuItem.Name = "aumentarFonteToolStripMenuItem";
            this.aumentarFonteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aumentarFonteToolStripMenuItem.Text = "Aumentar Fonte";
            this.aumentarFonteToolStripMenuItem.Click += new System.EventHandler(this.aumentarFonteToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem1
            // 
            this.fontSizeToolStripMenuItem1.Name = "fontSizeToolStripMenuItem1";
            this.fontSizeToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.fontSizeToolStripMenuItem1.Text = "Diminuir Fonte";
            this.fontSizeToolStripMenuItem1.Click += new System.EventHandler(this.fontSizeToolStripMenuItem1_Click);
            // 
            // txt_logFiltrado
            // 
            this.txt_logFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_logFiltrado.Location = new System.Drawing.Point(12, 27);
            this.txt_logFiltrado.Name = "txt_logFiltrado";
            this.txt_logFiltrado.ReadOnly = true;
            this.txt_logFiltrado.Size = new System.Drawing.Size(1300, 489);
            this.txt_logFiltrado.TabIndex = 1;
            this.txt_logFiltrado.Text = "";
            this.txt_logFiltrado.TextChanged += new System.EventHandler(this.txt_logFiltrado_TextChanged);
            // 
            // LogFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 528);
            this.Controls.Add(this.txt_logFiltrado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogFiltrado";
            this.Text = "LogFiltrado";
            this.Load += new System.EventHandler(this.LogFiltrado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirNoNotepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aumentarFonteToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txt_logFiltrado;
    }
}