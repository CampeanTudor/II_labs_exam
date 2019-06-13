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

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "userData.txt");
            {
                string username;
                username = streamReader.ReadLine();
                textBox1.Text = username;

                string password;
                password = streamReader.ReadLine();
                textBox2.Text = password;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text);  
            form2.Show();

        }
    }
}
