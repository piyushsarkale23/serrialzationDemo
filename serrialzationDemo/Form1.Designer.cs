namespace serrialzationDemo
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
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnsoapwr = new System.Windows.Forms.Button();
            this.btnwr = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.soapread = new System.Windows.Forms.Button();
            this.btnjsonr = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Departmentid";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(101, 106);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(100, 26);
            this.textbox3.TabIndex = 2;
            this.textbox3.Text = "location";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Department name";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(84, 162);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(126, 34);
            this.btnwrite.TabIndex = 4;
            this.btnwrite.Text = "binarywrite";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(85, 238);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(125, 36);
            this.btnxmlwrite.TabIndex = 5;
            this.btnxmlwrite.Text = "XML write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnsoapwr
            // 
            this.btnsoapwr.Location = new System.Drawing.Point(101, 306);
            this.btnsoapwr.Name = "btnsoapwr";
            this.btnsoapwr.Size = new System.Drawing.Size(111, 32);
            this.btnsoapwr.TabIndex = 6;
            this.btnsoapwr.Text = "SOAP write";
            this.btnsoapwr.UseVisualStyleBackColor = true;
            // 
            // btnwr
            // 
            this.btnwr.Location = new System.Drawing.Point(296, 162);
            this.btnwr.Name = "btnwr";
            this.btnwr.Size = new System.Drawing.Size(114, 34);
            this.btnwr.TabIndex = 7;
            this.btnwr.Text = "binarywrite";
            this.btnwr.UseVisualStyleBackColor = true;
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(296, 238);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(114, 36);
            this.btnxmlread.TabIndex = 8;
            this.btnxmlread.Text = "XML read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            // 
            // soapread
            // 
            this.soapread.Location = new System.Drawing.Point(310, 306);
            this.soapread.Name = "soapread";
            this.soapread.Size = new System.Drawing.Size(114, 32);
            this.soapread.TabIndex = 9;
            this.soapread.Text = "SOAP read";
            this.soapread.UseVisualStyleBackColor = true;
            // 
            // btnjsonr
            // 
            this.btnjsonr.Location = new System.Drawing.Point(458, 245);
            this.btnjsonr.Name = "btnjsonr";
            this.btnjsonr.Size = new System.Drawing.Size(104, 29);
            this.btnjsonr.TabIndex = 10;
            this.btnjsonr.Text = "JSON read";
            this.btnjsonr.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(469, 329);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(274, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(274, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 26);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(263, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 26);
            this.textBox6.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnjsonr);
            this.Controls.Add(this.soapread);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnwr);
            this.Controls.Add(this.btnsoapwr);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnsoapwr;
        private System.Windows.Forms.Button btnwr;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button soapread;
        private System.Windows.Forms.Button btnjsonr;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

