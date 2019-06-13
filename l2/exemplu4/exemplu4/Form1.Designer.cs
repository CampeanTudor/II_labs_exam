namespace exemplu4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nr2 = new System.Windows.Forms.TextBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.Nr1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numarul1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarul2";
            // 
            // Nr2
            // 
            this.Nr2.Location = new System.Drawing.Point(93, 108);
            this.Nr2.Name = "Nr2";
            this.Nr2.Size = new System.Drawing.Size(100, 20);
            this.Nr2.TabIndex = 2;
            this.Nr2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(93, 311);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(100, 20);
            this.Rezultat.TabIndex = 3;
            this.Rezultat.TextChanged += new System.EventHandler(this.Rezultat_TextChanged);
            // 
            // Nr1
            // 
            this.Nr1.Location = new System.Drawing.Point(93, 35);
            this.Nr1.Name = "Nr1";
            this.Nr1.Size = new System.Drawing.Size(100, 20);
            this.Nr1.TabIndex = 4;
            this.Nr1.TextChanged += new System.EventHandler(this.Nr1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(249, 38);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(249, 105);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(249, 218);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(75, 23);
            this.devide.TabIndex = 8;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(249, 162);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 9;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(249, 308);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 361);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nr1);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.Nr2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nr2;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.TextBox Nr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button clear;
    }
}

