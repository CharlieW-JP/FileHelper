
namespace FileHelper.Views
{
    partial class View_FileExtentionChange
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
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.originEx = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.newEx = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_filePath
            // 
            this.lbl_filePath.AutoSize = true;
            this.lbl_filePath.Location = new System.Drawing.Point(19, 69);
            this.lbl_filePath.Name = "lbl_filePath";
            this.lbl_filePath.Size = new System.Drawing.Size(80, 17);
            this.lbl_filePath.TabIndex = 1;
            this.lbl_filePath.Text = "ファイルパス";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 216);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(205, 62);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "変換開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // originEx
            // 
            this.originEx.AutoSize = true;
            this.originEx.Location = new System.Drawing.Point(19, 127);
            this.originEx.Name = "originEx";
            this.originEx.Size = new System.Drawing.Size(56, 17);
            this.originEx.TabIndex = 3;
            this.originEx.Text = "元拡張子";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 23);
            this.textBox2.TabIndex = 4;
            // 
            // newEx
            // 
            this.newEx.AutoSize = true;
            this.newEx.Location = new System.Drawing.Point(18, 180);
            this.newEx.Name = "newEx";
            this.newEx.Size = new System.Drawing.Size(56, 17);
            this.newEx.TabIndex = 5;
            this.newEx.Text = "新拡張子";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 23);
            this.textBox3.TabIndex = 6;
            // 
            // View_FileExtentionChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.newEx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.originEx);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lbl_filePath);
            this.Controls.Add(this.textBox1);
            this.Name = "View_FileExtentionChange";
            this.Text = "View_FileExtentionChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_filePath;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label originEx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label newEx;
        private System.Windows.Forms.TextBox textBox3;
    }
}