namespace MCPLOGViewer.View
{
    partial class MapaSIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaSIP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mensagens = new System.Windows.Forms.Label();
            this.lbl_debugIDs = new System.Windows.Forms.Label();
            this.txt_SipText = new System.Windows.Forms.RichTextBox();
            this.lst_infos = new System.Windows.Forms.ListBox();
            this.lst_debugids = new System.Windows.Forms.ListBox();
            this.lbl_textoSIP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_mensagens, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_debugIDs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_SipText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst_infos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst_debugids, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_textoSIP, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.73418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.26582F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 410);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_mensagens
            // 
            this.lbl_mensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mensagens.AutoSize = true;
            this.lbl_mensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagens.Location = new System.Drawing.Point(152, 0);
            this.lbl_mensagens.Name = "lbl_mensagens";
            this.lbl_mensagens.Size = new System.Drawing.Size(308, 71);
            this.lbl_mensagens.TabIndex = 5;
            this.lbl_mensagens.Text = "Mensagens";
            this.lbl_mensagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_debugIDs
            // 
            this.lbl_debugIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_debugIDs.AutoSize = true;
            this.lbl_debugIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debugIDs.Location = new System.Drawing.Point(3, 0);
            this.lbl_debugIDs.Name = "lbl_debugIDs";
            this.lbl_debugIDs.Size = new System.Drawing.Size(143, 71);
            this.lbl_debugIDs.TabIndex = 4;
            this.lbl_debugIDs.Text = "Ligações";
            this.lbl_debugIDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SipText
            // 
            this.txt_SipText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SipText.Location = new System.Drawing.Point(466, 74);
            this.txt_SipText.Name = "txt_SipText";
            this.txt_SipText.ReadOnly = true;
            this.txt_SipText.Size = new System.Drawing.Size(795, 333);
            this.txt_SipText.TabIndex = 2;
            this.txt_SipText.Text = "";
            // 
            // lst_infos
            // 
            this.lst_infos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_infos.FormattingEnabled = true;
            this.lst_infos.Location = new System.Drawing.Point(152, 74);
            this.lst_infos.Name = "lst_infos";
            this.lst_infos.Size = new System.Drawing.Size(308, 329);
            this.lst_infos.TabIndex = 1;
            this.lst_infos.SelectedIndexChanged += new System.EventHandler(this.lst_infos_SelectedIndexChanged);
            // 
            // lst_debugids
            // 
            this.lst_debugids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_debugids.FormattingEnabled = true;
            this.lst_debugids.Location = new System.Drawing.Point(3, 74);
            this.lst_debugids.Name = "lst_debugids";
            this.lst_debugids.Size = new System.Drawing.Size(143, 329);
            this.lst_debugids.TabIndex = 0;
            this.lst_debugids.SelectedIndexChanged += new System.EventHandler(this.lst_debugids_SelectedIndexChanged);
            // 
            // lbl_textoSIP
            // 
            this.lbl_textoSIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_textoSIP.AutoSize = true;
            this.lbl_textoSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textoSIP.Location = new System.Drawing.Point(466, 0);
            this.lbl_textoSIP.Name = "lbl_textoSIP";
            this.lbl_textoSIP.Size = new System.Drawing.Size(795, 71);
            this.lbl_textoSIP.TabIndex = 3;
            this.lbl_textoSIP.Text = "Texto da Mensagem";
            this.lbl_textoSIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MapaSIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MapaSIP";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MapaSIP";
            this.Load += new System.EventHandler(this.MapaSIP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lst_debugids;
        private System.Windows.Forms.ListBox lst_infos;
        private System.Windows.Forms.RichTextBox txt_SipText;
        private System.Windows.Forms.Label lbl_mensagens;
        private System.Windows.Forms.Label lbl_debugIDs;
        private System.Windows.Forms.Label lbl_textoSIP;
    }
}