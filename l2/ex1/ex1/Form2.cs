using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form2 : Form
    {
        public string labelText = "defaultValue";

        public Form2(string labelTextReceived)
        {
            InitializeComponent();
            this.labelText = "Welcome, " + labelTextReceived+"!";
            showMessage.Text = labelText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
