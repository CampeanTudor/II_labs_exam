namespace exemplu3
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
            this.buttonOpenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenForm
            // 
            this.buttonOpenForm.Location = new System.Drawing.Point(212, 345);
            this.buttonOpenForm.Name = "buttonOpenForm";
            this.buttonOpenForm.Size = new System.Drawing.Size(155, 34);
            this.buttonOpenForm.TabIndex = 0;
            this.buttonOpenForm.Text = "Click";
            this.buttonOpenForm.UseVisualStyleBackColor = true;
            this.buttonOpenForm.Click += new System.EventHandler(this.buttonOpenForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenForm;
    }
}

