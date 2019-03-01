namespace PicArchiveApp1
{
    partial class frmFind
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lstPic = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(223, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(9, 26);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(208, 20);
            this.txtFind.TabIndex = 1;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(9, 353);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(282, 138);
            this.txtComments.TabIndex = 4;
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.White;
            this.picMain.Location = new System.Drawing.Point(297, 11);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(599, 479);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 6;
            this.picMain.TabStop = false;
            this.picMain.DoubleClick += new System.EventHandler(this.picMain_DoubleClick);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(9, 68);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(208, 264);
            this.lstFiles.TabIndex = 9;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // lstPic
            // 
            this.lstPic.FormattingEnabled = true;
            this.lstPic.Location = new System.Drawing.Point(223, 68);
            this.lstPic.Name = "lstPic";
            this.lstPic.Size = new System.Drawing.Size(65, 264);
            this.lstPic.TabIndex = 11;
            this.lstPic.SelectedIndexChanged += new System.EventHandler(this.lstPic_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Коментарі";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(223, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 502);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPic);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.btnFind);
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук архіву";
            this.Load += new System.EventHandler(this.frmFind_Load);
            this.Resize += new System.EventHandler(this.frmFind_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.ListBox lstPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}