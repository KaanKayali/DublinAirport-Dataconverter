namespace DublinAirport_Prototype
{
    partial class Readfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readfile));
            this.previewTableDgv = new System.Windows.Forms.DataGridView();
            this.previewLabel = new System.Windows.Forms.Label();
            this.radiobuttonPanel = new System.Windows.Forms.Panel();
            this.HourlyRb = new System.Windows.Forms.RadioButton();
            this.monthlyRb = new System.Windows.Forms.RadioButton();
            this.WeeklyRb = new System.Windows.Forms.RadioButton();
            this.DailyRb = new System.Windows.Forms.RadioButton();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.TotalrowsLabel = new System.Windows.Forms.Label();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewTableDgv)).BeginInit();
            this.radiobuttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // previewTableDgv
            // 
            this.previewTableDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTableDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.previewTableDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.previewTableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewTableDgv.Location = new System.Drawing.Point(13, 44);
            this.previewTableDgv.Margin = new System.Windows.Forms.Padding(4);
            this.previewTableDgv.Name = "previewTableDgv";
            this.previewTableDgv.RowTemplate.Height = 31;
            this.previewTableDgv.Size = new System.Drawing.Size(758, 500);
            this.previewTableDgv.TabIndex = 6;
            this.previewTableDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previewTableDgv_CellContentClick);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(9, 16);
            this.previewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(82, 24);
            this.previewLabel.TabIndex = 7;
            this.previewLabel.Text = "Preview:";
            // 
            // radiobuttonPanel
            // 
            this.radiobuttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobuttonPanel.Controls.Add(this.HourlyRb);
            this.radiobuttonPanel.Controls.Add(this.monthlyRb);
            this.radiobuttonPanel.Controls.Add(this.WeeklyRb);
            this.radiobuttonPanel.Controls.Add(this.DailyRb);
            this.radiobuttonPanel.Location = new System.Drawing.Point(840, 44);
            this.radiobuttonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.radiobuttonPanel.Name = "radiobuttonPanel";
            this.radiobuttonPanel.Size = new System.Drawing.Size(147, 181);
            this.radiobuttonPanel.TabIndex = 8;
            this.radiobuttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.radiobuttonPanel_Paint);
            // 
            // HourlyRb
            // 
            this.HourlyRb.AutoSize = true;
            this.HourlyRb.Checked = true;
            this.HourlyRb.Location = new System.Drawing.Point(22, 18);
            this.HourlyRb.Margin = new System.Windows.Forms.Padding(4);
            this.HourlyRb.Name = "HourlyRb";
            this.HourlyRb.Size = new System.Drawing.Size(83, 28);
            this.HourlyRb.TabIndex = 3;
            this.HourlyRb.TabStop = true;
            this.HourlyRb.Text = "Hourly";
            this.HourlyRb.UseVisualStyleBackColor = true;
            this.HourlyRb.CheckedChanged += new System.EventHandler(this.HourlyRb_CheckedChanged);
            // 
            // monthlyRb
            // 
            this.monthlyRb.AutoSize = true;
            this.monthlyRb.Location = new System.Drawing.Point(22, 126);
            this.monthlyRb.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyRb.Name = "monthlyRb";
            this.monthlyRb.Size = new System.Drawing.Size(94, 28);
            this.monthlyRb.TabIndex = 2;
            this.monthlyRb.TabStop = true;
            this.monthlyRb.Text = "Monthly";
            this.monthlyRb.UseVisualStyleBackColor = true;
            this.monthlyRb.CheckedChanged += new System.EventHandler(this.monthlyRb_CheckedChanged);
            // 
            // WeeklyRb
            // 
            this.WeeklyRb.AutoSize = true;
            this.WeeklyRb.Location = new System.Drawing.Point(22, 90);
            this.WeeklyRb.Margin = new System.Windows.Forms.Padding(4);
            this.WeeklyRb.Name = "WeeklyRb";
            this.WeeklyRb.Size = new System.Drawing.Size(90, 28);
            this.WeeklyRb.TabIndex = 1;
            this.WeeklyRb.TabStop = true;
            this.WeeklyRb.Text = "Weekly";
            this.WeeklyRb.UseVisualStyleBackColor = true;
            this.WeeklyRb.CheckedChanged += new System.EventHandler(this.WeeklyRb_CheckedChanged);
            // 
            // DailyRb
            // 
            this.DailyRb.AutoSize = true;
            this.DailyRb.Location = new System.Drawing.Point(22, 54);
            this.DailyRb.Margin = new System.Windows.Forms.Padding(4);
            this.DailyRb.Name = "DailyRb";
            this.DailyRb.Size = new System.Drawing.Size(68, 28);
            this.DailyRb.TabIndex = 0;
            this.DailyRb.Text = "Daily";
            this.DailyRb.UseVisualStyleBackColor = true;
            this.DailyRb.CheckedChanged += new System.EventHandler(this.DailyRb_CheckedChanged);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.Location = new System.Drawing.Point(798, 502);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(6);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(172, 42);
            this.downloadBtn.TabIndex = 9;
            this.downloadBtn.Text = "Download file";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(253, 16);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(80, 24);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "No error";
            // 
            // TotalrowsLabel
            // 
            this.TotalrowsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalrowsLabel.AutoSize = true;
            this.TotalrowsLabel.Location = new System.Drawing.Point(794, 472);
            this.TotalrowsLabel.Name = "TotalrowsLabel";
            this.TotalrowsLabel.Size = new System.Drawing.Size(101, 24);
            this.TotalrowsLabel.TabIndex = 11;
            this.TotalrowsLabel.Text = "Total rows:";
            // 
            // LoadingGif
            // 
            this.LoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("LoadingGif.Image")));
            this.LoadingGif.Location = new System.Drawing.Point(798, 425);
            this.LoadingGif.Margin = new System.Windows.Forms.Padding(6);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(59, 41);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingGif.TabIndex = 12;
            this.LoadingGif.TabStop = false;
            this.LoadingGif.Visible = false;
            this.LoadingGif.Click += new System.EventHandler(this.LoadingGif_Click);
            // 
            // Readfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 613);
            this.Controls.Add(this.LoadingGif);
            this.Controls.Add(this.TotalrowsLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.radiobuttonPanel);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.previewTableDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Readfile";
            this.Text = "Convertdata";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Readfile_FormClosed);
            this.Load += new System.EventHandler(this.Readfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewTableDgv)).EndInit();
            this.radiobuttonPanel.ResumeLayout(false);
            this.radiobuttonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView previewTableDgv;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.Panel radiobuttonPanel;
        private System.Windows.Forms.RadioButton monthlyRb;
        private System.Windows.Forms.RadioButton WeeklyRb;
        private System.Windows.Forms.RadioButton DailyRb;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.RadioButton HourlyRb;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label TotalrowsLabel;
        private System.Windows.Forms.PictureBox LoadingGif;
    }
}