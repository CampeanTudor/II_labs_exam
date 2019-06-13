using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab5 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        string correctName, correctPass;
        public MainWindow() {
            InitializeComponent();
            string[] text = File.ReadAllLines("pass.txt");
            correctName = text[0];
            correctPass = text[1];
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SolidColorBrush magicBrush = (SolidColorBrush)this.Resources["magicBrush"];
            if(slider1!=null) {
                magicBrush.Color = Color.FromRgb((byte)slider1.Value, (byte)slider1.Value, 100);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(nameTextBox.Text.ToString().Trim().ToLower()==correctName.ToLower()) {
                if(passTextBox.Text.ToString().Trim().ToLower()==correctPass.ToLower()) {
                    WelcomeWindow fereastra = new WelcomeWindow(correctName);
                    fereastra.Show();
                }
            }
        }
    }
}
