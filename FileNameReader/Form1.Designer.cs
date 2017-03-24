namespace FileNameReader
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
            this.headtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openDirectoryBtn = new System.Windows.Forms.Button();
            this.outPut = new System.Windows.Forms.Button();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headtext
            // 
            this.headtext.Location = new System.Drawing.Point(83, 22);
            this.headtext.Name = "headtext";
            this.headtext.Size = new System.Drawing.Size(93, 21);
            this.headtext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "头部字符串";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(60, 88);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(461, 153);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // openDirectoryBtn
            // 
            this.openDirectoryBtn.Location = new System.Drawing.Point(365, 20);
            this.openDirectoryBtn.Name = "openDirectoryBtn";
            this.openDirectoryBtn.Size = new System.Drawing.Size(75, 23);
            this.openDirectoryBtn.TabIndex = 4;
            this.openDirectoryBtn.Text = "打开文件夹";
            this.openDirectoryBtn.UseVisualStyleBackColor = true;
            this.openDirectoryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // outPut
            // 
            this.outPut.Location = new System.Drawing.Point(446, 20);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(75, 23);
            this.outPut.TabIndex = 5;
            this.outPut.Text = "输出";
            this.outPut.UseVisualStyleBackColor = true;
            this.outPut.Click += new System.EventHandler(this.button2_Click);
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(60, 61);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(461, 21);
            this.DirectoryPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "屁股字符串";
            // 
            // endtext
            // 
            this.endtext.Location = new System.Drawing.Point(264, 22);
            this.endtext.Name = "endtext";
            this.endtext.Size = new System.Drawing.Size(93, 21);
            this.endtext.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.openDirectoryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headtext);
            this.Name = "Form1";
            this.Text = "文件夹文件名提取器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox headtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openDirectoryBtn;
        private System.Windows.Forms.Button outPut;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endtext;
    }
}

