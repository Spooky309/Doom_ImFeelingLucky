namespace doom_imfeelinglucky
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadinginfo = new System.Windows.Forms.Label();
            this.isTerry = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.btnViewTxt = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkForceUpd = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download a WAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to your favourite DOOM source port";
            // 
            // loadinginfo
            // 
            this.loadinginfo.AutoSize = true;
            this.loadinginfo.Location = new System.Drawing.Point(12, 120);
            this.loadinginfo.Name = "loadinginfo";
            this.loadinginfo.Size = new System.Drawing.Size(0, 13);
            this.loadinginfo.TabIndex = 4;
            // 
            // isTerry
            // 
            this.isTerry.AutoSize = true;
            this.isTerry.Checked = true;
            this.isTerry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isTerry.Location = new System.Drawing.Point(12, 94);
            this.isTerry.Name = "isTerry";
            this.isTerry.Size = new System.Drawing.Size(140, 17);
            this.isTerry.TabIndex = 5;
            this.isTerry.Text = "Include Terry (Warning!)";
            this.isTerry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Information";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 136);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(497, 118);
            this.logBox.TabIndex = 7;
            // 
            // btnViewTxt
            // 
            this.btnViewTxt.Location = new System.Drawing.Point(126, 65);
            this.btnViewTxt.Name = "btnViewTxt";
            this.btnViewTxt.Size = new System.Drawing.Size(67, 23);
            this.btnViewTxt.TabIndex = 8;
            this.btnViewTxt.Text = "View TXT";
            this.btnViewTxt.UseVisualStyleBackColor = true;
            this.btnViewTxt.Click += new System.EventHandler(this.btnViewTxt_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(199, 65);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(47, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save WAD For Later";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkForceUpd
            // 
            this.chkForceUpd.AutoSize = true;
            this.chkForceUpd.Location = new System.Drawing.Point(158, 94);
            this.chkForceUpd.Name = "chkForceUpd";
            this.chkForceUpd.Size = new System.Drawing.Size(122, 17);
            this.chkForceUpd.TabIndex = 11;
            this.chkForceUpd.Text = "Force Filelist Update";
            this.chkForceUpd.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(475, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(34, 23);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Info";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 266);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkForceUpd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnViewTxt);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isTerry);
            this.Controls.Add(this.loadinginfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "I\'m Feeling Lucky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loadinginfo;
        private System.Windows.Forms.CheckBox isTerry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button btnViewTxt;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkForceUpd;
        private System.Windows.Forms.Button btnHelp;
    }
}

