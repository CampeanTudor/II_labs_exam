namespace ex1
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
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.ItemHeight = 16;
            this.listBox_Univ.Location = new System.Drawing.Point(12, 64);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(191, 228);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.ListBox_Univ_SelectedIndexChanged_1);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.ItemHeight = 16;
            this.listBox_Fac.Location = new System.Drawing.Point(359, 64);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(200, 228);
            this.listBox_Fac.TabIndex = 1;
            this.listBox_Fac.SelectedIndexChanged += new System.EventHandler(this.ListBox_Fac_SelectedIndexChanged);
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(423, 380);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 22);
            this.textBox_City.TabIndex = 2;
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(423, 496);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_CodeUniv.TabIndex = 3;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(89, 462);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Insert.TabIndex = 5;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 626);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.textBox_CodeUniv);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.listBox_Fac);
            this.Controls.Add(this.listBox_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Button button_Insert;
    }
}

