using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Name = "MainWindow";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Double.Parse(inputATextBox.Text);
                double b = Double.Parse(inputBTextBox.Text);
                double c = Double.Parse(inputCTextBox.Text);

                double p = (a+b+c)/2;
                double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

                outputLabel.Content += result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("данные не корректны" + ex.Message);
            }

        }

        private void openWindowButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow window = new SecondWindow();
            window.Show();
            this.Hide();
        }
    }
}
