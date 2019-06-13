using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        private string operation;
        private int operand1;
        private int operand2;
        private int result;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuComboBox_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            operation = menuComboBox.SelectedItem.ToString();
            operand1 = int.Parse(textBox1.Text);
            operand2 = int.Parse(textBox3.Text);

            switch (operation)
            {
                case "AND":
                    and();
                    break;
                case "Or":
                    or();
                    break;
                case "XOR":               
                   xor();
                   break;
            }
            textBox2.Text = result.ToString();
            

        }

        private void and()
        {
            result = operand1 & operand2;
        }

        private void or()
        {
            result = operand1 | operand2;
        }

        private void xor()
        {
            result = operand1 ^ operand2;
        }
    }
}
