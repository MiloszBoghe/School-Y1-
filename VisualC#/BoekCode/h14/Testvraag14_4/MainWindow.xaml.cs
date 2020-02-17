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

namespace Testvraag14_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] demoarr = { 1, 2, 3, 4, 5 };

        public MainWindow()
        {
            InitializeComponent();
            Display(demoarr, textBox1);
        }

        public void Display(int[] array, TextBox outputTextBox)
        {
            outputTextBox.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                outputTextBox.AppendText(
                    Convert.ToString(array[i]));
                outputTextBox.AppendText(
                    Environment.NewLine);
            }
        }
    }
}
