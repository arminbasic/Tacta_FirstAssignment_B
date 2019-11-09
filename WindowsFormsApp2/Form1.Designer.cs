namespace WindowsFormsApp2
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
            this.Enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Word = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Finish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(354, 45);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(112, 32);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Location = new System.Drawing.Point(33, 52);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(33, 13);
            this.Word.TabIndex = 2;
            this.Word.Text = "Word";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(107, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 156);
            this.panel1.TabIndex = 3;
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(456, 123);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 23);
            this.Finish.TabIndex = 4;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(107, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 100);
            this.panel2.TabIndex = 5;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(562, 123);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(456, 191);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Player1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(456, 214);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Player2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(456, 238);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Player3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(456, 261);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Player4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(456, 284);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 17);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.Text = "Player5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(13, 132);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(0, 13);
            this.repeatLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.repeatLabel);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label repeatLabel;
    }
}

