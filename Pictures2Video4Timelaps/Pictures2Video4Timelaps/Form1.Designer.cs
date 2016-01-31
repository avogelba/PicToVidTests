namespace Pictures2Video4Timelaps
{
    partial class Form1
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
            this.buttonMakeVideo = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxHOriginal = new System.Windows.Forms.TextBox();
            this.textBoxWOriginal = new System.Windows.Forms.TextBox();
            this.textBoxHNew = new System.Windows.Forms.TextBox();
            this.textBoxWNew = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelHi = new System.Windows.Forms.Label();
            this.labelWd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxOutFormat = new System.Windows.Forms.CheckBox();
            this.labelSwithOutFormat = new System.Windows.Forms.Label();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelFPSHint = new System.Windows.Forms.Label();
            this.labelSecHint = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxWaterMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMakeVideo
            // 
            this.buttonMakeVideo.Location = new System.Drawing.Point(640, 450);
            this.buttonMakeVideo.Name = "buttonMakeVideo";
            this.buttonMakeVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeVideo.TabIndex = 0;
            this.buttonMakeVideo.Text = "Make Video";
            this.buttonMakeVideo.UseVisualStyleBackColor = true;
            this.buttonMakeVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(55, 61);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 1;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(504, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxHOriginal
            // 
            this.textBoxHOriginal.Location = new System.Drawing.Point(99, 12);
            this.textBoxHOriginal.Name = "textBoxHOriginal";
            this.textBoxHOriginal.ReadOnly = true;
            this.textBoxHOriginal.Size = new System.Drawing.Size(50, 20);
            this.textBoxHOriginal.TabIndex = 3;
            // 
            // textBoxWOriginal
            // 
            this.textBoxWOriginal.Location = new System.Drawing.Point(361, 12);
            this.textBoxWOriginal.Name = "textBoxWOriginal";
            this.textBoxWOriginal.ReadOnly = true;
            this.textBoxWOriginal.Size = new System.Drawing.Size(50, 20);
            this.textBoxWOriginal.TabIndex = 4;
            // 
            // textBoxHNew
            // 
            this.textBoxHNew.Location = new System.Drawing.Point(177, 13);
            this.textBoxHNew.Name = "textBoxHNew";
            this.textBoxHNew.ReadOnly = true;
            this.textBoxHNew.Size = new System.Drawing.Size(50, 20);
            this.textBoxHNew.TabIndex = 5;
            this.textBoxHNew.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBoxHNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            this.textBoxHNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBoxWNew
            // 
            this.textBoxWNew.Location = new System.Drawing.Point(439, 12);
            this.textBoxWNew.Name = "textBoxWNew";
            this.textBoxWNew.Size = new System.Drawing.Size(50, 20);
            this.textBoxWNew.TabIndex = 6;
            this.textBoxWNew.TextChanged += new System.EventHandler(this.textBoxHightNew_TextChanged);
            this.textBoxWNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHightNew_KeyDown);
            this.textBoxWNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHightNew_KeyPress);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(10, 35);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(23, 13);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "File";
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Location = new System.Drawing.Point(55, 16);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(38, 13);
            this.labelHi.TabIndex = 8;
            this.labelHi.Text = "Height";
            // 
            // labelWd
            // 
            this.labelWd.AutoSize = true;
            this.labelWd.Location = new System.Drawing.Point(317, 18);
            this.labelWd.Name = "labelWd";
            this.labelWd.Size = new System.Drawing.Size(35, 13);
            this.labelWd.TabIndex = 9;
            this.labelWd.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "->";
            // 
            // checkBoxOutFormat
            // 
            this.checkBoxOutFormat.AutoSize = true;
            this.checkBoxOutFormat.Location = new System.Drawing.Point(738, 113);
            this.checkBoxOutFormat.Name = "checkBoxOutFormat";
            this.checkBoxOutFormat.Size = new System.Drawing.Size(48, 17);
            this.checkBoxOutFormat.TabIndex = 12;
            this.checkBoxOutFormat.Text = "MP4";
            this.checkBoxOutFormat.UseVisualStyleBackColor = true;
            this.checkBoxOutFormat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelSwithOutFormat
            // 
            this.labelSwithOutFormat.AutoSize = true;
            this.labelSwithOutFormat.Location = new System.Drawing.Point(611, 114);
            this.labelSwithOutFormat.Name = "labelSwithOutFormat";
            this.labelSwithOutFormat.Size = new System.Drawing.Size(121, 13);
            this.labelSwithOutFormat.TabIndex = 13;
            this.labelSwithOutFormat.Text = "Output Format MP4/AVI";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(640, 179);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(53, 20);
            this.textBoxFPS.TabIndex = 14;
            this.textBoxFPS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFPS_KeyDown);
            this.textBoxFPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFPS_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "fps";
            // 
            // textBoxSec
            // 
            this.textBoxSec.Location = new System.Drawing.Point(640, 205);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(45, 20);
            this.textBoxSec.TabIndex = 16;
            this.textBoxSec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSec_KeyDown);
            this.textBoxSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSec_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "sec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(726, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "A. Vogelbacher";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelFPSHint
            // 
            this.labelFPSHint.AutoSize = true;
            this.labelFPSHint.Location = new System.Drawing.Point(700, 185);
            this.labelFPSHint.Name = "labelFPSHint";
            this.labelFPSHint.Size = new System.Drawing.Size(68, 13);
            this.labelFPSHint.TabIndex = 22;
            this.labelFPSHint.Text = "labelFPSHint";
            // 
            // labelSecHint
            // 
            this.labelSecHint.AutoSize = true;
            this.labelSecHint.Location = new System.Drawing.Point(700, 212);
            this.labelSecHint.Name = "labelSecHint";
            this.labelSecHint.Size = new System.Drawing.Size(67, 13);
            this.labelSecHint.TabIndex = 23;
            this.labelSecHint.Text = "labelSecHint";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(738, 450);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // textBoxWaterMark
            // 
            this.textBoxWaterMark.Location = new System.Drawing.Point(640, 278);
            this.textBoxWaterMark.Name = "textBoxWaterMark";
            this.textBoxWaterMark.Size = new System.Drawing.Size(198, 20);
            this.textBoxWaterMark.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "mark";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(763, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Make a Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWaterMark);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelSecHint);
            this.Controls.Add(this.labelFPSHint);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.labelSwithOutFormat);
            this.Controls.Add(this.checkBoxOutFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWd);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxWNew);
            this.Controls.Add(this.textBoxHNew);
            this.Controls.Add(this.textBoxWOriginal);
            this.Controls.Add(this.textBoxHOriginal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonMakeVideo);
            this.MinimumSize = new System.Drawing.Size(885, 582);
            this.Name = "Form1";
            this.Text = "Picture2Video";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMakeVideo;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxHOriginal;
        private System.Windows.Forms.TextBox textBoxWOriginal;
        private System.Windows.Forms.TextBox textBoxHNew;
        private System.Windows.Forms.TextBox textBoxWNew;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelHi;
        private System.Windows.Forms.Label labelWd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxOutFormat;
        private System.Windows.Forms.Label labelSwithOutFormat;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelFPSHint;
        private System.Windows.Forms.Label labelSecHint;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBoxWaterMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

