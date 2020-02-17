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

namespace Exercise07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < Convert.ToInt32(numberTextBox.Text)+1; i++)
            {
                int number = Convert.ToInt32(numberTextBox.Text);
                resultTextBlock.Width = number * 55;
                resultTextBlock.Height = number * 55;
                resultTextBlock.Text = "\t";

                for (int top = 1; top <= number; top++)
                {
                    resultTextBlock.Text += top + "\t";
                }
                resultTextBlock.Text += "\n\n";

                for (int n = 1; n <= number; n++)
                {
                    resultTextBlock.Text += n + "\t";
                    for (int result = 1; result <= number; result++)
                    {
                        resultTextBlock.Text += (n * result) + "\t";
                    }
                    resultTextBlock.Text += "\n";
                }
            }
        }
    }

}
