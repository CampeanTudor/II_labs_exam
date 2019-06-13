namespace ex2
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.copiazaBttn = new System.Windows.Forms.Button();
            this.stergeBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 82);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // copiazaBttn
            // 
            this.copiazaBttn.Location = new System.Drawing.Point(232, 86);
            this.copiazaBttn.Name = "copiazaBttn";
            this.copiazaBttn.Size = new System.Drawing.Size(75, 23);
            this.copiazaBttn.TabIndex = 2;
            this.copiazaBttn.Text = "Copiaza";
            this.copiazaBttn.UseVisualStyleBackColor = true;
            this.copiazaBttn.Click += new System.EventHandler(this.copiazaBttn_Click);
            // 
            // stergeBttn
            // 
            this.stergeBttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stergeBttn.Location = new System.Drawing.Point(232, 166);
            this.stergeBttn.Name = "stergeBttn";
            this.stergeBttn.Size = new System.Drawing.Size(75, 23);
            this.stergeBttn.TabIndex = 3;
            this.stergeBttn.Text = "Sterge";
            this.stergeBttn.UseVisualStyleBackColor = true;
            this.stergeBttn.Click += new System.EventHandler(this.stergeBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(175, 296);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(75, 23);
            this.exitBttn.TabIndex = 4;
            this.exitBttn.Text = "exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.stergeBttn);
            this.Controls.Add(this.copiazaBttn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button copiazaBttn;
        private System.Windows.Forms.Button stergeBttn;
        private System.Windows.Forms.Button exitBttn;
    }
}

