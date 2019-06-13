using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        private string pictureChosen;
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureChosen = menu.SelectedItem.ToString();

            switch (pictureChosen)
            {
                case "Car":
                    pictureBox1.Image = Image.FromFile("C:/Users/campe/Desktop/Partea Intelectuala/Facultate/An3/Sem2/II/l2/ex4/images/car.jpg");
                    break;

                case "House":
                    pictureBox1.Image = Image.FromFile("C:/Users/campe/Desktop/Partea Intelectuala/Facultate/An3/Sem2/II/l2/ex4/images/house.jpg");
                    break;

                case "Animal":
                    pictureBox1.Image = Image.FromFile("C:/Users/campe/Desktop/Partea Intelectuala/Facultate/An3/Sem2/II/l2/ex4/images/animal.jpg");
                    break;
            }
        }

        private void ShowRadioBttns_Click(object sender, EventArgs e)
        {
            string firstChoise = (group1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)).Text;
            string secondChoise = (group2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)).Text;
            MessageBox.Show("Radio buttons pressed:"+firstChoise+" "+secondChoise);
        }
    }
}
