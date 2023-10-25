namespace DublinAirport_Prototype
{
    partial class Uploadfile
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploadfile));
            this.uploadBtn = new System.Windows.Forms.Button();
            this.filelistLbl = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.removeFileBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(60, 57);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(292, 81);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload file";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // filelistLbl
            // 
            this.filelistLbl.AutoSize = true;
            this.filelistLbl.Location = new System.Drawing.Point(70, 142);
            this.filelistLbl.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.filelistLbl.Name = "filelistLbl";
            this.filelistLbl.Size = new System.Drawing.Size(0, 24);
            this.filelistLbl.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 24;
            this.fileList.Location = new System.Drawing.Point(60, 172);
            this.fileList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(288, 124);
            this.fileList.TabIndex = 2;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // removeFileBtn
            // 
            this.removeFileBtn.Enabled = false;
            this.removeFileBtn.Location = new System.Drawing.Point(60, 306);
            this.removeFileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeFileBtn.Name = "removeFileBtn";
            this.removeFileBtn.Size = new System.Drawing.Size(292, 65);
            this.removeFileBtn.TabIndex = 3;
            this.removeFileBtn.Text = "Remove file";
            this.removeFileBtn.UseVisualStyleBackColor = true;
            this.removeFileBtn.Click += new System.EventHandler(this.removeFileBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(60, 378);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(204, 59);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Load";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // LoadingGif
            // 
            this.LoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("LoadingGif.Image")));
            this.LoadingGif.Location = new System.Drawing.Point(273, 382);
            this.LoadingGif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(79, 55);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingGif.TabIndex = 5;
            this.LoadingGif.TabStop = false;
            this.LoadingGif.Visible = false;
            // 
            // Uploadfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 491);
            this.Controls.Add(this.LoadingGif);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.removeFileBtn);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.filelistLbl);
            this.Controls.Add(this.uploadBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uploadfile";
            this.Text = "Uploadfile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label filelistLbl;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button removeFileBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox LoadingGif;
    }
}

