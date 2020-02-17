using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int previous;
        int result;
        int next;
        int count;
        string vorigeOperator;
        string reset;
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayTextBlock.Text == "0")
            {
                displayTextBlock.Text = Convert.ToString(((Button)sender).Content);
            }
            else
            {
                displayTextBlock.Text += Convert.ToString(((Button)sender).Content);
            }
            reset = "";
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {

            if (count == 0)
            {
                previous = Convert.ToInt32(displayTextBlock.Text);
                displayTextBlock.Text = "";
            }
            else
            {
                next = Convert.ToInt32(displayTextBlock.Text);
                displayTextBlock.Text = "";
            }
            if (Convert.ToString(((Button)sender).Content) == "+")
            {
                vorigeOperator = "+";
                if (count == 0)
                {
                    result = previous;
                }
                else
                {
                    result += next;
                }
            }
            else if (Convert.ToString(((Button)sender).Content) == "-")
            {
                vorigeOperator = "-";
                if (count == 0)
                {
                    result = previous;
                }
                else
                {
                    result -= next;
                }
            }
            else
            {
                if (vorigeOperator == "+")
                {
                    result += next;
                }
                else if (vorigeOperator == "-")
                {
                    result -= next;
                }
                if (Convert.ToString(((Button)sender).Content) == "=")
                {
                    displayTextBlock.Text = Convert.ToString(result);
                    reset = "=";
                }
            }
            count++;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text = "0";
            previous = 0;
            next = 0;
            result = 0;
            count = 0;
        }
    }
}
