namespace MCPLOGViewer.View
{
    partial class Preferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferencias));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_palavras = new System.Windows.Forms.ListBox();
            this.btn_adcicionar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_palavra = new System.Windows.Forms.TextBox();
            this.gbo_destaque = new System.Windows.Forms.GroupBox();
            this.rbt_sem_destaque = new System.Windows.Forms.RadioButton();
            this.rbt_destaque = new System.Windows.Forms.RadioButton();
            this.cmb_fonte = new System.Windows.Forms.ComboBox();
            this.cmb_tamanho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbo_destaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escreva aqui as palavras que terão destaque no texto. \n As palavras serão destaca" +
    "das na função de busca por ligações.";
            // 
            // lst_palavras
            // 
            this.lst_palavras.FormattingEnabled = true;
            this.lst_palavras.Location = new System.Drawing.Point(3, 136);
            this.lst_palavras.Name = "lst_palavras";
            this.lst_palavras.Size = new System.Drawing.Size(341, 95);
            this.lst_palavras.TabIndex = 3;
            this.lst_palavras.SelectedIndexChanged += new System.EventHandler(this.lst_palavras_SelectedIndexChanged);
            // 
            // btn_adcicionar
            // 
            this.btn_adcicionar.Location = new System.Drawing.Point(3, 107);
            this.btn_adcicionar.Name = "btn_adcicionar";
            this.btn_adcicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adcicionar.TabIndex = 4;
            this.btn_adcicionar.Text = "Adicionar";
            this.btn_adcicionar.UseVisualStyleBackColor = true;
            this.btn_adcicionar.Click += new System.EventHandler(this.btn_adcicionar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(269, 107);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_palavra
            // 
            this.txt_palavra.Location = new System.Drawing.Point(3, 81);
            this.txt_palavra.Name = "txt_palavra";
            this.txt_palavra.Size = new System.Drawing.Size(341, 20);
            this.txt_palavra.TabIndex = 6;
            this.txt_palavra.Text = "Adicionar palavras";
            this.txt_palavra.Click += new System.EventHandler(this.txt_palavra_Click);
            // 
            // gbo_destaque
            // 
            this.gbo_destaque.Controls.Add(this.rbt_sem_destaque);
            this.gbo_destaque.Controls.Add(this.rbt_destaque);
            this.gbo_destaque.Location = new System.Drawing.Point(357, 136);
            this.gbo_destaque.Name = "gbo_destaque";
            this.gbo_destaque.Size = new System.Drawing.Size(193, 70);
            this.gbo_destaque.TabIndex = 22;
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
            // 
            // cmb_fonte
            // 
            this.cmb_fonte.FormattingEnabled = true;
            this.cmb_fonte.Items.AddRange(new object[] {
            "Consolas",
            "Arial",
            "Roboto",
            "Microsoft Sans Serif"});
            this.cmb_fonte.Location = new System.Drawing.Point(76, 273);
            this.cmb_fonte.Name = "cmb_fonte";
            this.cmb_fonte.Size = new System.Drawing.Size(121, 21);
            this.cmb_fonte.TabIndex = 23;
            // 
            // cmb_tamanho
            // 
            this.cmb_tamanho.FormattingEnabled = true;
            this.cmb_tamanho.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cmb_tamanho.Location = new System.Drawing.Point(303, 273);
            this.cmb_tamanho.Name = "cmb_tamanho";
            this.cmb_tamanho.Size = new System.Drawing.Size(41, 21);
            this.cmb_tamanho.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo da fonte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tamanho da fonte";
            // 
            // Preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tamanho);
            this.Controls.Add(this.cmb_fonte);
            this.Controls.Add(this.gbo_destaque);
            this.Controls.Add(this.txt_palavra);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_adcicionar);
            this.Controls.Add(this.lst_palavras);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preferencias";
            this.Text = "Palavras Importantes";
            this.Load += new System.EventHandler(this.PalavrasImportantes_Load);
            this.Disposed += new System.EventHandler(this.PalavrasImportantes_Disposed);
            this.gbo_destaque.ResumeLayout(false);
            this.gbo_destaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_palavras;
        private System.Windows.Forms.Button btn_adcicionar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_palavra;
        private System.Windows.Forms.GroupBox gbo_destaque;
        private System.Windows.Forms.RadioButton rbt_sem_destaque;
        private System.Windows.Forms.RadioButton rbt_destaque;
        private System.Windows.Forms.ComboBox cmb_fonte;
        private System.Windows.Forms.ComboBox cmb_tamanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}