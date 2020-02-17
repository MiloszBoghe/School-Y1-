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

namespace opgave1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = calculate();
                double b = calculate2();
                uitkomstA.Content = a;
                uitkomstB.Content = b;
            }
            catch (ArgumentNullException) when (getalA.Text==null||getalB.Text==null)
            {
                MessageBox.Show("Geef een getal in beide velden in.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Geef getallen in.");
            }

            catch (OverflowException)
            {
                MessageBox.Show("geef een kleiner getal in.");
            }
        }
            private double calculate()
            {
                return Double.Parse(getalA.Text) / Double.Parse(getalB.Text);
            }

            private double calculate2()
            {
                return Double.Parse(getalB.Text) / Double.Parse(getalA.Text);
            }
        }
    }
