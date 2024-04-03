namespace _22520085_VoDucAnh
{
    partial class LAB02_bai01
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
            this.DocFile = new System.Windows.Forms.Button();
            this.GhiFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DocFile
            // 
            this.DocFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DocFile.Location = new System.Drawing.Point(78, 40);
            this.DocFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocFile.Name = "DocFile";
            this.DocFile.Size = new System.Drawing.Size(147, 65);
            this.DocFile.TabIndex = 0;
            this.DocFile.Text = "ĐỌC FILE";
            this.DocFile.UseVisualStyleBackColor = false;
            this.DocFile.Click += new System.EventHandler(this.DocFile_Click);
            // 
            // GhiFile
            // 
            this.GhiFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GhiFile.Location = new System.Drawing.Point(78, 154);
            this.GhiFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GhiFile.Name = "GhiFile";
            this.GhiFile.Size = new System.Drawing.Size(147, 65);
            this.GhiFile.TabIndex = 1;
            this.GhiFile.Text = "GHI FILE";
            this.GhiFile.UseVisualStyleBackColor = false;
            this.GhiFile.Click += new System.EventHandler(this.GhiFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(294, 40);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 301);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LAB02_bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GhiFile);
            this.Controls.Add(this.DocFile);
            this.Name = "LAB02_bai01";
            this.Text = "Bài 01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DocFile;
        private System.Windows.Forms.Button GhiFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}