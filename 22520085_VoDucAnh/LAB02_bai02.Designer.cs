namespace _22520085_VoDucAnh
{
    partial class LAB02_bai02
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.filename = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.linecount = new System.Windows.Forms.TextBox();
            this.wordscount = new System.Windows.Forms.TextBox();
            this.charactercount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read from File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character count";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(538, 14);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 428);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(212, 87);
            this.filename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(318, 26);
            this.filename.TabIndex = 8;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(212, 142);
            this.size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(318, 26);
            this.size.TabIndex = 9;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(212, 205);
            this.url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(318, 26);
            this.url.TabIndex = 10;
            // 
            // linecount
            // 
            this.linecount.Location = new System.Drawing.Point(212, 270);
            this.linecount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.linecount.Name = "linecount";
            this.linecount.Size = new System.Drawing.Size(318, 26);
            this.linecount.TabIndex = 11;
            // 
            // wordscount
            // 
            this.wordscount.Location = new System.Drawing.Point(212, 339);
            this.wordscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wordscount.Name = "wordscount";
            this.wordscount.Size = new System.Drawing.Size(318, 26);
            this.wordscount.TabIndex = 12;
            // 
            // charactercount
            // 
            this.charactercount.Location = new System.Drawing.Point(212, 416);
            this.charactercount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.charactercount.Name = "charactercount";
            this.charactercount.Size = new System.Drawing.Size(318, 26);
            this.charactercount.TabIndex = 13;
            // 
            // LAB02_bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 490);
            this.Controls.Add(this.charactercount);
            this.Controls.Add(this.wordscount);
            this.Controls.Add(this.linecount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.size);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LAB02_bai02";
            this.Text = "Bài 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox linecount;
        private System.Windows.Forms.TextBox wordscount;
        private System.Windows.Forms.TextBox charactercount;
    }
}