namespace PicArchiveApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPaste = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.txtACT = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDPicSelector = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPicSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(8, 12);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(116, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Вставити з буфера";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.White;
            this.picMain.Location = new System.Drawing.Point(183, 12);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(483, 369);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 6;
            this.picMain.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picSave
            // 
            this.picSave.Location = new System.Drawing.Point(198, 51);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(36, 36);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 11;
            this.picSave.TabStop = false;
            this.picSave.Visible = false;
            // 
            // txtACT
            // 
            this.txtACT.Location = new System.Drawing.Point(8, 60);
            this.txtACT.Name = "txtACT";
            this.txtACT.Size = new System.Drawing.Size(143, 20);
            this.txtACT.TabIndex = 12;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(8, 102);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(166, 250);
            this.txtComments.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Коментарі";
            // 
            // nUDPicSelector
            // 
            this.nUDPicSelector.Location = new System.Drawing.Point(136, 14);
            this.nUDPicSelector.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nUDPicSelector.Name = "nUDPicSelector";
            this.nUDPicSelector.Size = new System.Drawing.Size(38, 20);
            this.nUDPicSelector.TabIndex = 16;
            this.nUDPicSelector.ValueChanged += new System.EventHandler(this.nUDPicSelector_ValueChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(158, 58);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(17, 23);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 392);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.nUDPicSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtACT);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.btnPaste);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новий архів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPicSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.TextBox txtACT;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDPicSelector;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnHelp;
    }
}

