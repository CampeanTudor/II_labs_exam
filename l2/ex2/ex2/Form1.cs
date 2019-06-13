using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = readTextFromFile();
        }

        private string readTextFromFile()
        {
            StreamReader streamReader = new StreamReader(path: "textBox1.txt");
            
            string text="";
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
                text = text + line;

            return text;
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void copiazaBttn_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void stergeBttn_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
